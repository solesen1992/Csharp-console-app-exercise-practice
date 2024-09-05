using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitialization.Model
{
    internal class Company
    {
        // Property for CompanyNo
        public int CompanyNo { get; set; }

        // Property for CompanyName
        public string? CompanyName { get; set; }

        // Primary constructor that only takes CompanyNo
        public Company(int companyNo)
        {
            CompanyNo = companyNo;
        }

        // Constructor that takes both CompanyNo and CompanyName
        public Company(int companyNo, string companyName) : this(companyNo)
        {
            CompanyName = companyName;
        }

        // Override ToString method to display both CompanyNo and CompanyName
        public override string ToString()
        {
            return $"Company No: {CompanyNo} \nCompany Name: {CompanyName}";
        }
    }
}
