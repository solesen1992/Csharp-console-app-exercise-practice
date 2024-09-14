using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InterfacesAndLists.Investment
{
    /**
     * The Painting class implements the IInvestment interface and represents a painting as an investment item.
     * It contains information such as the painting's title, artist, year, condition, and price. 
     * The PriceCalculate method simply returns the provided price since no complex calculation is needed. 
     * The InvestSummary method returns a formatted string summarizing the painting's details, including its title, artist, year, condition, and price.
     */
    internal class Painting : IInvestment
    {
        // Constructor to initialize a painting with its title, artist, year, condition, and price.
        public Painting(string title, string artist, int year, string condition, int price)
        {
            Title = title;
            Artist = artist;
            Year = year;
            Condition = condition;
            Price = price;
        }

        // Properties
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public string Condition { get; set; }
        public int Price { get; set; }

        // Methods
        // Method to return the price of the painting (no calculation needed as the price is directly provided).
        public int PriceCalculate()
        {
            return Price;  // The price is already provided, so no calculation needed
        }

        // Method to provide a summary of the painting investment.
        public string InvestSummary()
        {
            // Returns a summary string that includes the title, artist, year, condition, and price of the painting.
            return $"Painting: {Title}, by {Artist}{Environment.NewLine}Year {Year}, Condition: {Condition}{Environment.NewLine}Price: {Price}";
        }
    }
}
