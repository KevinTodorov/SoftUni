using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Engine_and_Tires
{
    class Car
    {
        public string Make { get; set; } = "VW";

        public string Model { get; set; } = "Golf";

        public int Year { get; set; } = 2025;

        public double FuelQuantity { get; set; } = 200;

        public double FuelConsumption { get; set; } = 10;

        private Engine engine;
        public Engine Engine { get; set; }

        private Tire[] tire;

        public Tire[] Tire { get; set; }

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
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tire = tires;
        }

       
    }
}
