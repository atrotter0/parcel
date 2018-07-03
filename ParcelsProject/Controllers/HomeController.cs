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
        public ActionResult ParcelResults()
        {
            Parcel package = new Parcel();
            return View(package);
        }
    }
}
