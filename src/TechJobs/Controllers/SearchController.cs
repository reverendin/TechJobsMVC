using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;
using System.Globalization;
using System.Threading;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results
        public IActionResult Results(string searchType, string searchTerm)
        {
            ViewBag.columns = ListController.columnChoices;

            if(searchTerm != null)
            {
                ViewBag.jobs = JobData.FindByValue(searchTerm);
                ViewBag.searchTerm = searchTerm;
            }
            else
            {
                return Redirect("/search");
            }

            return View("Index");
        }

    }
}
