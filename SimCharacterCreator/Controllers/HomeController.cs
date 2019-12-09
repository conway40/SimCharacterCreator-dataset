using SimCharacterCreator.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimCharacterCreator.Controllers
{
    

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.LinkText = "Index";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.LinkText = "About";
            ViewBag.Message = "About the Sims Character Creator";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.LinkText = "Contact";
            ViewBag.Message = "Contact the developer";

            return View();
        }
        public ActionResult Help()
        {
            ViewBag.LinkText = "Help";
            ViewBag.Message = "Need help using this application? Start Here!";
            return View();
        }
    }
}