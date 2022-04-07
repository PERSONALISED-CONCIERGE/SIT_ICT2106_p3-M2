using personalised_concierge_m1.Models.Entities.Itineraries;
using personalised_concierge_m1.Models.Interfaces.Itineraries;
using System.Collections.Generic;
using System.Linq;

namespace personalised_concierge_m1.Data.Itineraries
{
    public class AscendingSort : ISortStrategy
    { 

        public string[] Sort(string[] list)
        {
            string temp;
            int n, i, j, l;

            l = list.Length;
            for (i = 0; i < l; i++)
            {
                for (j = 0; j < l - 1; j++)
                {
                    if (list[j].CompareTo(list[j + 1]) > 0)
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }


    }
}
