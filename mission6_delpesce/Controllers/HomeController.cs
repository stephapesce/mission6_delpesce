using Microsoft.AspNetCore.Mvc;
using mission6_delpesce.Models;
using System.Diagnostics;

namespace mission6_delpesce.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult entermovies()
        {
            return View();
        }


        public IActionResult gettoknowjoel()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Entermovies() 
        {
            return View("entermovies");
        }

        [HttpPost]
        public IActionResult Entermovies(Movies response)
        {
            return View("conf", response);
        }



    }
}
