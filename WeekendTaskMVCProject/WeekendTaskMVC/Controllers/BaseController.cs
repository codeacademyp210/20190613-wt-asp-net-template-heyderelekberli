using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeekendTaskMVC.Models;

namespace WeekendTaskMVC.Controllers
{
    public class BaseController : Controller
    {
       protected BemaxEntities db;
        protected Slider Slider;
        protected Advisor Advisor;
        protected OurWork OurWork;
        protected Project Project;
        protected Choos Choose;
        protected Post Post;
        protected Tester Tester;
        protected Partner Partner;
        public BaseController()
        {
            db = new BemaxEntities();
            Slider = db.Sliders.FirstOrDefault();
            Advisor = db.Advisors.FirstOrDefault();
            OurWork = db.OurWorks.FirstOrDefault();
            Project = db.Projects.FirstOrDefault();
            Choose = db.Chooses.FirstOrDefault();
            Post = db.Posts.FirstOrDefault();
            Tester = db.Testers.FirstOrDefault();
            Partner = db.Partners.FirstOrDefault();
            
        }

    }
}