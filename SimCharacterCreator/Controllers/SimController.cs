using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SimCharacterCreator.BusinessLayer;
using SimCharacterCreator.DataAccessLayer;
using SimCharacterCreator.Models;

namespace SimCharacterCreator.Controllers
{
    public class SimController : Controller
    {
        private static SimBusiness _simBusiness = new SimBusiness();

        // GET: Sim
        public ActionResult Index()
        {
            ViewBag.LinkText = "Sim";
            // velis
            return View(_simBusiness.AllSims());
        }

        // GET: Sim/Details/5
        public ActionResult Details(int id)
        {
            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sim sim = _simBusiness.SimById(id);
            if (sim == null)
            {
                return HttpNotFound();
            }
            return View(sim);
        }
        

        // GET: Sim/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sim/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Sim sim)
        {
            try
            {
                _simBusiness.AddSim(sim);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(sim);
            }
        }

        // GET: Sim/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sim sim = _simBusiness.SimById(id);
            if (sim == null)
            {
                return HttpNotFound();
            }
            return View(sim);
        }

        // POST: Sim/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Sim sim)
        {
            try
            {
                // TODO: Add update logic here
                _simBusiness.DeleteSim(sim);
                _simBusiness.AddSim(sim);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(sim);
            }
        }

        // GET: Sim/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sim sim = _simBusiness.SimById(id);
            if (sim == null)
            {
                return HttpNotFound();
            }
            return View(sim);
        }

        // POST: Sim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sim sim = _simBusiness.SimById(id);
            _simBusiness.DeleteSim(sim);
            return RedirectToAction("Index");
        }
    }
}
