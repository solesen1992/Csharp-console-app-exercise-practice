using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InterfacesAndLists.Investment
{
    public interface IInvestment
    {
        public int PriceCalculate();

        public string InvestSummary();
    }
}
