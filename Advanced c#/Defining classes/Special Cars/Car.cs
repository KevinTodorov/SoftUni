using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Cars
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public int EngineIndex { get; set; }
        public int TireIndex { get; set; }


        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, int engineIndex, int tireIndex)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            EngineIndex = engineIndex;
            TireIndex = tireIndex;
        }

        public bool Drive()
        {
            if (Year >= 2017)
            {
                if (FuelQuantity > 20 / FuelConsumption)
                {
                    FuelQuantity -= 20 / FuelConsumption;
                }else return false;

                return true;
            }
            return false;
        }
    }
}
