using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InterfacesAndLists.Investment
{
    internal class Painting : IInvestment
    {
        // Constructor
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
        public int PriceCalculate()
        {
            return Price;  // The price is already provided, so no calculation needed
        }

        public string InvestSummary()
        {
            return $"Painting: {Title}, by {Artist}{Environment.NewLine}Year {Year}, Condition: {Condition}{Environment.NewLine}Price: {Price}";
        }
    }
}
