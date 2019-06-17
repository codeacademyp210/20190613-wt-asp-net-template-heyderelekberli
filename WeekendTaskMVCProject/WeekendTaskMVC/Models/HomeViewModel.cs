using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeekendTaskMVC.Models
{
    public class HomeViewModel
    {
        public List<Slider> Slider { get; set; }
        public List<Advisor> Advisor { get; set; }
        public List<OurWork> OurWork { get; set; }
        public List<Project> Project { get; set; }
        public List<Choos> Choose { get; set; }
        public List<Post> Post { get; set; }
        public List<Tester> Tester { get; set; }
        public List<Partner> Partner { get; set; }

    }
}