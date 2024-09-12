using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InterfacesAndLists.Investment
{
    public class Boat : IInvestment
    {
        public enum BoatCondition {
            Unknown,
            Awful,
            Bad,
            Medium,
            Good,
            Perfect
        }

        // Constructor
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
        public int PriceCalculate()
        {
            int foundPrice = Length * MeterPrice;
            return foundPrice;
        }

        public string InvestSummary()
        {
            string summ = "Boat: " + Description + Environment.NewLine + "Length " + Length;
            summ += Environment.NewLine + "Price: " + PriceCalculate() + Environment.NewLine + "Condition: " + Condition;
            return summ;
        }
    }
}
