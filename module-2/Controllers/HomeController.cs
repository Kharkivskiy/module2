using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace module_2.Controllers
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


        public ActionResult TASK1()
        {
            return View();
        }

        public ActionResult TASK2()
        {
            return View();
        }

        public ActionResult TASK3()
        {
            return View();
        }


    }
}