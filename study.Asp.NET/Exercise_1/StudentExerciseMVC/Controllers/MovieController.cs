using Microsoft.AspNetCore.Mvc;
using StudentExerciseMVC.Models;

namespace StudentExerciseMVC.Controllers
{
    public class MovieController : Controller
    {

        private static List<MovieViewModel> _movies = new List<MovieViewModel>();
        //Navigation /Movie/Movies
        public IActionResult Movies()
        {

            /*
            MovieViewModel movie = new MovieViewModel()
            {
                MovieTitle = "The GodFather",
                Director = "Francis Ford Coppola",
                Year = 1972
            }; 
            */

            return View(_movies);
        }
        public IActionResult Create()
        {

            var movieVm = new MovieViewModel();
            return View(movieVm);
        }
        public IActionResult CreateMovie(MovieViewModel movieViewModel)
        {
            _movies.Add(movieViewModel);
            return RedirectToAction(nameof(Movies));
        }
    }
}
