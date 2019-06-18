using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeekendTaskMVC.Models;

namespace WeekendTaskMVC.Controllers
{
    public class AboutController : BaseController
    {
        // GET: About
        public ActionResult Index()
        {
            HomeViewModel models = new HomeViewModel();
            models.Reason = db.Reasons.ToList();
            models.Team = db.Teams.ToList();
            models.Testimonial = db.Testimonials.ToList();
            models.Partner = db.Partners.ToList();

            return View(models);
        }
    }
}