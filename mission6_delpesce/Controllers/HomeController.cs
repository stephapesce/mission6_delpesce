using Microsoft.AspNetCore.Mvc;
using mission6_delpesce.Models;
using System.Diagnostics;

namespace mission6_delpesce.Controllers
{
    public class HomeController : Controller
    {
        private MovieCollectionContext _context;
        public HomeController(MovieCollectionContext temp) //Constructor
        { 
            _context = temp;
        
        }

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

            _context.Movies.Add(response); //add record to the database 
            _context.SaveChanges();

            return View("conf", response);
        }



    }
}
