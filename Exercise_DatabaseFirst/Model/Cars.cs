using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DatabaseFirst.Model
{
    public class Cars
    {
        public Cars(string licenseplate, string make, string model, string color)
        {
            Licenseplate = licenseplate;
            Make = make;
            Model = model;
            Color = color;
        }

        public string Licenseplate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public override string? ToString()
        {
            string carStr = $"Licenseplate: {Licenseplate}, Make: {Make}, Model: {Model}, Color: {Color}";
            return carStr;
        }
    }
}
