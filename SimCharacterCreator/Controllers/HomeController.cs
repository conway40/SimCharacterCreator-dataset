﻿using SimCharacterCreator.DataAccessLayer;
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
            Session["DataSet"] = SeedData.GenerateListOfCharacters();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}