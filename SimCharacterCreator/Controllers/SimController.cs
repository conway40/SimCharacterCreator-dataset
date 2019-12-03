using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimCharacterCreator.BusinessLayer;
using SimCharacterCreator.DataAccessLayer;

namespace SimCharacterCreator.Controllers
{
    public class SimController : Controller
    {
        private static SimBusiness _simBusiness = new SimBusiness();

        // GET: Sim
        public ActionResult Index()
        {
            // velis
            return View(_simBusiness.AllSims());
        }

        // GET: Sim/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Sim/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sim/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sim/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sim/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sim/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sim/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
