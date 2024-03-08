using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = _context.Categories

                .OrderBy(x => x.CategoryName)
                .ToList();



            return View("entermovies");
        }






        [HttpPost]
        public IActionResult Entermovies(Movie response)

        {

            _context.Movies.Add(response); //add record to the database 
            _context.SaveChanges();

            return View("conf", response);
        }


        public IActionResult MovieEntries() 
        {

            //Linq 
            var movies = _context.Movies
                .Include(x=> x.Category)
                .OrderBy(x => x.Title).ToList(); 

            return View(movies);  
        
        }

        [HttpGet]
        public IActionResult Edit(int id) 

        {

            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);


            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("entermovies", recordToEdit );
    
        }



        [HttpPost]

        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            return RedirectToAction("MovieEntries");
        }



        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }


        [HttpPost]
        public IActionResult Delete(Movie application )
        {
            _context.Movies.Remove(application); 
            _context.SaveChanges();
            return RedirectToAction("MovieEntries");
        }

    }
}
