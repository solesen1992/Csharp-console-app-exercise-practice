using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InterfacesAndLists.Investment
{
    /**
     * The House class implements the IInvestment interface and represents a house as an investment item.
     * It includes attributes such as the house's address, square meters, price per square meter, condition, 
     * and description. The class ensures that square meter values are valid (greater than 0) through property 
     * validation and calculates the house's total price with overflow protection. It also provides a summary 
     * of the house's investment details, including its price and condition.
     */
    public class House : IInvestment
    {
        // Enum to define different conditions a house can be in.
        public enum HouseCondition
        { 
            Unknown,
            Awful,
            Bad,
            Medium,
            Good,
            Perfect
        }

        // Constructor to initialize a house with its address, square meters, price per square meter, condition, and description.
        public House(string inAddress, int inSquareMeters, int inSquareMeterPrice, HouseCondition inCondition, string inDescription)
        {
            Address = inAddress;
            SquareMeters = inSquareMeters;
            SquareMeterPrice = inSquareMeterPrice;
            Condition = inCondition;
            Description = inDescription;
        }

        /* Backing field for SquareMeters */
        private int _squareMeters;

        /* Properties */
        public string Address { get; set; }
        // Property for SquareMeters with validation to ensure it's greater than 0.
        public int SquareMeters 
        {
            // Gets the square meters.
            get => _squareMeters;
            set
            {
                // Ensures the value is greater than 0.
                if (value > 0)
                {
                    // Sets the value if it's valid.
                    _squareMeters = value;
                }
                else
                {
                    // Sets square meters to 0 if the value is invalid (could throw an exception instead).
                    _squareMeters = 0;
                }
            }
        }
        public int SquareMeterPrice { get; set; }
        public HouseCondition Condition { get; set; }
        public string Description { get; set; }

        /* Methods */
        // Method to calculate the total price of the house, with protection against overflow.
        public int PriceCalculate()
        {
            try
            {
                // First, cast SquareMeters to long to prevent overflow during multiplication
                long totalPrice = (long)SquareMeters * SquareMeterPrice;

                // Then, check if totalPrice fits within the bounds of int
                if (totalPrice > int.MaxValue || totalPrice < int.MinValue)
                {
                    // Throw exception if the totalPrice overflows.
                    throw new OverflowException();
                }

                // If no overflow, return the totalPrice cast back to int
                return (int)totalPrice;
            }
            catch (OverflowException)
            {
                // Handle overflow by printing an error message.
                Console.WriteLine("Overflow occurred during price calculation.");
                return -1; // Return error value (or handle as needed)
            }
        }

        // Method to provide a summary of the house investment.
        public string InvestSummary()
        {
            // Calculate the price of the house.
            int price = PriceCalculate();
            // Check if overflow occurred and set appropriate price text.
            string priceText = price == -1 ? "Overflow!" : price.ToString();
            // Create a summary string that includes the address, square meters, price, and condition.
            string summ = "House: " + Address + Environment.NewLine + "Area = " + SquareMeters;
            summ += Environment.NewLine + "Price: " + PriceCalculate() + Environment.NewLine + "Condition: " + Condition;
            // Return the summary.
            return summ;
        }
    }
}
