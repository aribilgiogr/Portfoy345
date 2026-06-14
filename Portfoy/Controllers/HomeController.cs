using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfoy.Controllers
{
    public class HomeController : Controller
    {
        // / veya /home veya /home/index
        public ActionResult Index()
        {
            return View();
        }

        // /home/about
        public ActionResult About()
        {
            return View();
        }

        // /home/contact
        public ActionResult Contact()
        {
            return View();
        }
    }
}