using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InterfacesAndLists.Investment
{
     /**
     * The Boat class implements the IInvestment interface and represents a boat as an investment item. 
     * It calculates the price based on the boat's length and price per meter, and stores information 
     * such as the condition, description, and year of registration. It provides a method to return a summary 
     * of the boat's investment details, including its price and condition.
     */
    public class Boat : IInvestment
    {
        // Enum to define different conditions a boat can be in.
        public enum BoatCondition {
            Unknown,
            Awful,
            Bad,
            Medium,
            Good,
            Perfect
        }

        // Constructor to initialize a boat with its length, meter price, condition, description, and registration year.
        public Boat(int inLength, int inMeterPrice, BoatCondition inCondition, string inDescription, int inRegYear)
        {
            Length = inLength;
            MeterPrice = inMeterPrice;
            Condition = inCondition;
            Description = inDescription;
            RegYear = inRegYear;
        }

        /* Properties */
        public int Length { get; set; }
        public int MeterPrice { get; set; }
        public BoatCondition Condition { get; set; }
        public string Description { get; set; }
        public int RegYear { get; set; }

        /* Methods */

        // Method to calculate the total price of the boat based on its length and meter price.
        public int PriceCalculate()
        {
            // Calculates the price by multiplying the length by the meter price.
            int foundPrice = Length * MeterPrice;
            // Returns the calculated price.
            return foundPrice;
        }

        // Method to provide a summary of the boat investment.
        public string InvestSummary()
        {
            // Starts the summary with the boat's description and length.
            string summ = "Boat: " + Description + Environment.NewLine + "Length " + Length;
            // Adds the calculated price and condition to the summary.
            summ += Environment.NewLine + "Price: " + PriceCalculate() + Environment.NewLine + "Condition: " + Condition;
            // Returns the summary.
            return summ;
        }
    }
}
