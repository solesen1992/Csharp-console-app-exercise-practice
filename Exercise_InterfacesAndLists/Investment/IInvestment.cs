using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InterfacesAndLists.Investment
{
    /**
     * The IInvestment interface defines the contract for investment items. 
     * Any class implementing this interface must provide an implementation for:
     * 
     * 1. PriceCalculate: A method that calculates and returns the price of the investment.
     * 2. InvestSummary: A method that returns a string summary of the investment details.
     * 
     * This interface can be implemented by various types of investment objects like houses, boats, etc.,
     * allowing them to have consistent behavior for price calculation and summarization.
     */
    public interface IInvestment
    {
        public int PriceCalculate();

        public string InvestSummary();
    }
}
