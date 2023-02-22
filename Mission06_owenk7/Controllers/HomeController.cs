using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission06_owenk7.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_owenk7.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _movieContext { get; set; }

        public HomeController(MovieContext x)
        {
            _movieContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FormView()
        {
            ViewBag.Categories = _movieContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult FormView(FormModel model)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Add(model);

                _movieContext.SaveChanges();

                return View("Confirmation", model);
            }
            else
            {
                ViewBag.Categories = _movieContext.Categories.ToList();

                return View(model);
            }
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = _movieContext.recommendations
                .Include(x => x.Category)
                .ToList();
            //.OrderBy(x => x.rating)
            //.Where(x => x.rating == "PG")

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();

            var movie = _movieContext.recommendations.Single(x => x.Movieid == id);

            return View("FormView", movie);
        }

        [HttpPost]
        public IActionResult Edit(FormModel editmodel)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Update(editmodel);
                _movieContext.SaveChanges();

                return RedirectToAction("MovieList");
            }
            else
            {
                ViewBag.Categories = _movieContext.Categories.ToList();

                return View("FormView", editmodel);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = _movieContext.recommendations.Single(x => x.Movieid == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(FormModel model)
        {
            _movieContext.recommendations.Remove(model);
            _movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}