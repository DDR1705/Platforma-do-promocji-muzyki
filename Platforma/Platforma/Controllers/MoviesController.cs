using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Platforma.Models; // Żeby mieć moliwość wywoływania z klas modelu

namespace Platforma.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Terminator" }; // Użycie pola Name z Models/Movie dzięki using Platforma.Models
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);

        }
        public ActionResult Index (int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex = {0} &sortBy= {1}", pageIndex, sortBy));

        }
    }
}