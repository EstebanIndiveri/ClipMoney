using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularMVCProject.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        public ActionResult Index()
        //public string Index()
        {
            //return "Algo algo algo";
            return View();
        }
    }
}