using Microsoft.AspNetCore.Mvc;
using ParcelsProject.Models;

namespace ParcelsProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult ParcelForm()
        {
            return View();
        }

        [HttpGet("/parcel_results")]
        public ActionResult ParcelResults(string name, int weight, int height, int length, int width)
        {
            Parcel package = new Parcel();
            package.SetSender(name);
            package.SetWeight(weight);
            package.SetHeight(height);
            package.SetLength(length);
            package.SetWidth(width);
            package.CalculateVolume();
            package.CalculateCost();
            package.SaveParcel();
            return View(Parcel.GetAll());
        }
    }
}
