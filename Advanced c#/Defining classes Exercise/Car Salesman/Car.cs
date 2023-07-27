using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Salesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }
        public Car(string model, Engine engine, string weight) : this(model, engine)
        {
            this.Model = model;
            this.Engine = engine;

            if (Char.IsDigit(weight[0]))
            {
                this.Weight = weight;
                this.Color = "n/a";
            }
            else
            {
                this.Color = weight;
                this.Weight = "n/a";
            }
        }

        public Car(string model, Engine engine, string weight, string color) : this(model, engine, weight)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }
    }
}
