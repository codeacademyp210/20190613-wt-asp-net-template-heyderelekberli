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
            models.Advisor = db.Advisors.ToList();
            models.OurWork= db.OurWorks.ToList();
            models.Project= db.Projects.ToList();
            models.Choose= db.Chooses.ToList();
            models.Post= db.Posts.ToList();
            models.Tester= db.Testers.ToList();
            models.Partner= db.Partners.ToList();
            return View(models);
        }
        public ActionResult Home1()
        {
            HomeViewModel models = new HomeViewModel();
            models.Slider = db.Sliders.ToList();
            models.Advisor = db.Advisors.ToList();
            models.OurWork = db.OurWorks.ToList();
            models.Project = db.Projects.ToList();
            models.Choose = db.Chooses.ToList();
            models.Post = db.Posts.ToList();
            models.Tester = db.Testers.ToList();
            models.Partner = db.Partners.ToList();
            return View(models);
         
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