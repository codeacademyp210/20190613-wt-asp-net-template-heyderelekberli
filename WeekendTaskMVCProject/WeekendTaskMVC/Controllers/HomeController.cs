using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeekendTaskMVC.Models;

namespace WeekendTaskMVC.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
           HomeViewModel models = new HomeViewModel();
            models.Slider = db.Sliders.ToList();
            return View(models);
        }
        public ActionResult Home1()
        {
            return View();
        }
        public ActionResult Home2()
        {
            return View();
        }
        public ActionResult Home3()
        {
            return View();
        }
        public ActionResult Home4()
        {
            return View();
        }
        public ActionResult Home5()
        {
            return View();
        }
        public ActionResult Home6()
        {
            return View();
        }
    }
}