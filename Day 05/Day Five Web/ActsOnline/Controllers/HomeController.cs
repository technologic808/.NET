using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActsOnline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Your services page.";
            ViewBag.MyList = new List<String> { "Diploma Course Services", "Research and Development Services" };
            Models.Course dac = new Models.Course();
            dac.CourseName = "DAC";
            dac.CourseDescription = "Diploma in Advanced Computing";
            ViewBag.MyCourse = dac;
            return View();
        }
    }
}