using Assignment_4_Movies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4_Movies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MovieFormContext _blahContext { get; set; }
        //constructor
        public HomeController(ILogger<HomeController> logger, MovieFormContext someName)
        {
            _logger = logger;
            _blahContext = someName;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var movies = _blahContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(movies);
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieCollection()
        {
            ViewBag.Categories = _blahContext.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult MovieCollection(MovieModel ar)
        {
            if (ModelState.IsValid) {
                _blahContext.Add(ar);
                _blahContext.SaveChanges();
                return View("submissionConf", ar);
            }
            else  {
                ViewBag.Categories = _blahContext.Categories.ToList();
                return View(ar);
            }          
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = _blahContext.Categories.ToList();

            var movie = _blahContext.Responses.Single(x => x.Movie_id == movieid);
            return View("MovieCollection", movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieModel movie)
        {
            if (ModelState.IsValid)
            {
            _blahContext.Update(movie);
            _blahContext.SaveChanges();

            return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Categories = _blahContext.Categories.ToList();
                return View();
            }

        }
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = _blahContext.Responses.Single(x => x.Movie_id == movieid);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(MovieModel movie)
        {
            _blahContext.Responses.Remove(movie);
            _blahContext.SaveChanges();

            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
