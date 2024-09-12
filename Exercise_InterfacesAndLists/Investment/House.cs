using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InterfacesAndLists.Investment
{
    public class House : IInvestment
    {
        public enum HouseCondition
        { 
            Unknown,
            Awful,
            Bad,
            Medium,
            Good,
            Perfect
        }

        // Constructor
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
        public int SquareMeters 
        {
            get => _squareMeters;
            set
            {
                if (value > 0)
                {
                    _squareMeters = value;
                }
                else
                {
                    _squareMeters = 0;  // Or you could throw an exception or set a default value
                }
            }
        }
        public int SquareMeterPrice { get; set; }
        public HouseCondition Condition { get; set; }
        public string Description { get; set; }

        /* Methods */
        public int PriceCalculate()
        {
            try
            {
                // First, cast SquareMeters to long to prevent overflow during multiplication
                long totalPrice = (long)SquareMeters * SquareMeterPrice;

                // Then, check if totalPrice fits within the bounds of int
                if (totalPrice > int.MaxValue || totalPrice < int.MinValue)
                {
                    throw new OverflowException();
                }

                // If no overflow, return the totalPrice cast back to int
                return (int)totalPrice;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow occurred during price calculation.");
                return -1; // Return error value (or handle as needed)
            }
        }

        public string InvestSummary()
        {
            int price = PriceCalculate();
            string priceText = price == -1 ? "Overflow!" : price.ToString();
            string summ = "House: " + Address + Environment.NewLine + "Area = " + SquareMeters;
            summ += Environment.NewLine + "Price: " + PriceCalculate() + Environment.NewLine + "Condition: " + Condition;
            return summ;
        }
    }
}
