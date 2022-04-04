using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;
using ParkingSystem.Data;
using ParkingSystem.Data.Models;

namespace ParkingSystem.Controllers
{
    public class CarController : Controller
    {
        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            Match carMatch = Regex.Match(car.ToString(), @"[A-Z]{2} [0-9]{4} [A-Z]{2}");

            if (carMatch.Success)
            {
                DataAccescs.Cars.Add(car);
                return Redirect("/");
            }
            else return Redirect("/");
        }

        [HttpPost]

        public IActionResult DeleteCar(string plateNumber)
        {
           Car car = DataAccescs.Cars.FirstOrDefault(x => x.PlateNumber == plateNumber);
           DataAccescs.Cars.Remove(car);
           return Redirect("/");
        }
    }
}
