using Microsoft.AspNetCore.Mvc;
using ParkingSystem.Data;
using ParkingSystem.Data.Models;

namespace ParkingSystem.Controllers
{
    public class CarController : Controller
    {
        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            if (!ModelState.IsValid)
            {
                return Redirect("/");
            }
            DataAccess.Cars.Add(car);
            return Redirect("/");
        }
        [HttpPost]
        public IActionResult DeleteCar(string plateNumber)
        {
            DataAccess.Cars.Remove(DataAccess.Cars.FirstOrDefault(x => x.PlateNumber == plateNumber));
            return Redirect("/");
        }
    }
}
