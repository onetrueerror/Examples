using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MinimalConfiguration.Models;
using OneTrueError.Reporting;

namespace MinimalConfiguration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "OneTrueError demonstration.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Post()
        {
            // exception will be detected and caught.
            // an error page is shown
            var repos = new FakeRepository();
            repos.Save();
            return RedirectToAction("Index");
        }

        public ActionResult PostViewModel(PostModel model)
        {
            // works with try/catch too
            try
            {
                var repos = new FakeRepository();
                repos.Save();
            }
            catch (Exception exception)
            {
                // just attach the model.
                OneTrue.Report(exception, model);

                /* Can also do like this:
                 
                OneTrue.Report(exception, new { MyViewModel = model, AdditionalData = new { Id = 1, Date = DateTime.Now } });
                
                 */
            }

            return View("Submitted");
        }
    }
}
