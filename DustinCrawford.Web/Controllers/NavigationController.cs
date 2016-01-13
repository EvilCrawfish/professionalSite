using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DustinCrawford.Web.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Resume()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}