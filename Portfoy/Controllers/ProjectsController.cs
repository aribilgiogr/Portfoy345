using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfoy.Controllers
{
    public class ProjectsController : Controller
    {
        // /Projects veya /Projects/Index
        public ActionResult Index()
        {
            return View();
        }

        // /Projects/Detail/{id}
        public ActionResult Detail(int id)
        {
            return View();
        }
    }
}