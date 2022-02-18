using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using personalised_concierge_m1.Models.Interfaces.Itineraries;
using personalised_concierge_m1.Models.Entities.Itineraries;
using personalised_concierge_m1.Data.Itineraries;
using personalised_concierge_m1.Models.Interfaces;

namespace personalised_concierge_m1.Controllers
{
    public class BudgetController : Controller
    {
        private Budget budget = new Budget();
        private static int currentExpensesId;
        private static double totalExpensesAmount;
        private static string selectedCurrency = "SGD";
        private static double BudgetLimit;
        private static int progressValue = 0;
        private static List<Expenses> expensesList = new List<Expenses>();
        private readonly IM2UnitOfWork _m2UnitOfWork;

        public BudgetController(IM2UnitOfWork m2UnitOfWork)
        {
            _m2UnitOfWork = m2UnitOfWork;
        }

        public IActionResult Index()
        {
            getMaxExpenseId();
            expensesList.Clear();
            selectedCurrency = "SGD";
            budget.TotalExpensesAmount = 0.0;
            totalExpensesAmount = 0.0;
            getBudgetLimit(0);
            getAllExpenses(0); // parameter takes in userid
            if(BudgetLimit != 0)
            {
                budget.BudgetRatio = Convert.ToInt32((totalExpensesAmount / BudgetLimit) * 100);
            }
            return View(budget);
        }

        public void getMaxExpenseId()
        {
            currentExpensesId = _m2UnitOfWork.BudgetDetails.findMaxExpensesId();
        }

        public void getAllExpenses(int userId)
        {
            var expensesLocalList = _m2UnitOfWork.BudgetDetails.findAllExpenses(userId);
            budget.ExpensesList = expensesLocalList;
            expensesList = expensesLocalList;
            foreach (var expense in expensesList)
            {
                if (expense.Currency != "SGD")
                {
                    double rate = getExchangeRate(expense.Currency, "SGD");
                    budget.TotalExpensesAmount += Math.Round(rate * expense.Amount, 2);
                    totalExpensesAmount += Math.Round(rate * expense.Amount, 2);
                }
                else
                {
                    budget.TotalExpensesAmount += expense.Amount;
                    totalExpensesAmount += expense.Amount;
                }
            }
        }

        [HttpPost]
        public JsonResult AddExpenses(Expenses expenses)
        {
            expenses.ExpensesId = ++currentExpensesId;
            _m2UnitOfWork.BudgetDetails.addExpenses(expenses);
            budget.ExpensesList.Add(expenses);
            expensesList.Add(expenses);

            if (expenses.Currency != selectedCurrency)
            {
                double rate = getExchangeRate(expenses.Currency, selectedCurrency);
                totalExpensesAmount = Math.Round(totalExpensesAmount + (rate * expenses.Amount), 2);
            }
            else
            {
                totalExpensesAmount += expenses.Amount;
                totalExpensesAmount = Math.Round(totalExpensesAmount, 2);
            }
            if(BudgetLimit == 0)
            {
                progressValue = 0;
            }
            else
            {
                progressValue = Convert.ToInt32((totalExpensesAmount / BudgetLimit) * 100);
            }
            var status = new { expensesId = currentExpensesId, expensesCurrency = expenses.Currency, Amount = expenses.Amount, Category = expenses.Category, Description = expenses.Description, currentAmount = totalExpensesAmount, currencyHeading = selectedCurrency, progressBar = progressValue };
            string jsonString = JsonConvert.SerializeObject(status);
            Debug.WriteLine("Added successfully");
            return new JsonResult(jsonString);
        }

        [HttpPost]
        public JsonResult deleteExpenses(int id)
        {
            _m2UnitOfWork.BudgetDetails.deleteExpenses(id);
            var item = expensesList.Find(x => x.ExpensesId == id);
            expensesList.Remove(item);
            if (item.Currency != selectedCurrency)
            {
                double rate = getExchangeRate(item.Currency, selectedCurrency);
                totalExpensesAmount = Math.Round(totalExpensesAmount - (rate * item.Amount), 2);
            }
            else
            {
                totalExpensesAmount -= item.Amount;
            }
            if(BudgetLimit != 0)
            {
                progressValue = Convert.ToInt32((totalExpensesAmount / BudgetLimit) * 100);
            }
            var status = new { Currency = selectedCurrency, currentAmount = totalExpensesAmount, progressBar = progressValue };
            string jsonString = JsonConvert.SerializeObject(status);

            return new JsonResult(jsonString);
        }

        public void getBudgetLimit(int userId)
        {
            double budgetLimitReturned = _m2UnitOfWork.BudgetDetails.findBudgetLimit(userId);
            BudgetLimit = budgetLimitReturned;
            budget.Budgetlimit = budgetLimitReturned;
        }

        [HttpPost]
        public JsonResult setBudget(Budget budget)
        {
            _m2UnitOfWork.BudgetDetails.updateBudgetLimit(budget);
            BudgetLimit = budget.Budgetlimit;
            if (BudgetLimit == 0)
            {
                progressValue = 0;
            }
            else
            {
                progressValue = Convert.ToInt32((totalExpensesAmount / BudgetLimit) * 100);
            }
            var status = new { currency = selectedCurrency, budgetLimit = budget.Budgetlimit, progressBar = progressValue };
            string jsonString = JsonConvert.SerializeObject(status);
            return new JsonResult(jsonString);
        }

        [HttpPost]
        public JsonResult updateSelectedCurrency(string currency)
        {
            double rate = getExchangeRate(selectedCurrency, currency);
            budget.Currency = currency;
            selectedCurrency = currency;
            totalExpensesAmount = Math.Round(rate * totalExpensesAmount, 2);
            BudgetLimit = Math.Round(rate * BudgetLimit, 2);
            progressValue = Convert.ToInt32((totalExpensesAmount / BudgetLimit) * 100);
            var status = new { currency = currency, currentAmount = totalExpensesAmount, budgetLimit = BudgetLimit, progressBar = progressValue };
            string jsonString = JsonConvert.SerializeObject(status);
            return new JsonResult(jsonString);
        }

        public double getExchangeRate(string from, string to)
        {
            string urlRequest = "https://api.getgeoapi.com/v2/currency/convert?api_key=bf87b7010453b056cc3d549bc5d2bad57f8b5f51&from=" + from + "&to=" + to + "&amount=1&format=json?api_key=bf87b7010453b056cc3d549bc5d2bad57f8b5f51";
            string urlTest = String.Format(urlRequest);
            WebRequest requestObject = WebRequest.Create(urlTest);
            requestObject.Method = "GET";
            HttpWebResponse responseObject = null;
            responseObject = (HttpWebResponse)requestObject.GetResponse();

            double exchangeRate;
            string resulttest = null;
            using (Stream stream = responseObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                resulttest = sr.ReadToEnd();
                dynamic myObject = JsonConvert.DeserializeObject<dynamic>(resulttest);
                exchangeRate = myObject["rates"][to]["rate"];
                Debug.WriteLine(exchangeRate);
                sr.Close();
            }
            return exchangeRate;
        }
    }
}
