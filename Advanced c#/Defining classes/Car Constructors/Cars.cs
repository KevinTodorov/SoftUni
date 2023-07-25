using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Constructors
{
    public class Car
    {
        //private string make;
        //private string model;
        //private int year;
        //private double fuelQuantity;
        //private double fuelConsumption;

        public string Make { get; set; } = "VW";

        public string Model { get; set; } = "Golf";

        public int Year { get; set; } = 2025;

        public double FuelQuantity { get; set; } = 200;

        public double FuelConsumption { get; set; } = 10;

        public Car()
        {

        }
        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

    }
}
