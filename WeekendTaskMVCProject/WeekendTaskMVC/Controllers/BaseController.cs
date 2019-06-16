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
        public BaseController()
        {
            db = new BemaxEntities();
            Slider = db.Sliders.FirstOrDefault();
        }

    }
}