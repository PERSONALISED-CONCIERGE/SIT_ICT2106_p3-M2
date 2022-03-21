using System;
using System.Collections.Generic;

namespace personalised_concierge_m1.Models.Entities.OtherServices
{

    // The Context defines the interface of interest to clients.
    public class Context
    {
        // The Context maintains a reference to one of the Strategy objects. The
        // Context does not know the concrete class of a strategy. It should
        // work with all strategies via the Strategy interface.
        private IStrategy _strategy;

        public Context()
        {
        }

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // Usually, the Context allows replacing a Strategy object at runtime.
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public IEnumerable<Review> DoSomeSortingLogic(string type, object data)
        {
            if(type == "ascending")
            {
                var result = this._strategy.SortASC(data);
                return result;
            }
            else if(type == "descending")
            {
                var result = this._strategy.SortDSC(data);
                return result;
            
            }
            return null;
            
        }
    }
}
