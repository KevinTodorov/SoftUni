using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raw_Data
{
    public class Tire
    {
        public double TirePressure { get; set; }
        public int Age { get; set; }

        public Tire(double tirePressure, int age)
        {
            TirePressure = tirePressure;
            Age = age;
        }
    }
}
