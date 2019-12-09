using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
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
        //public ActionResult Index()
        //{
        //    ViewBag.LinkText = "Sim";
        //    // velis
        //    return View(_simBusiness.AllSims());
        //}
        public ActionResult Index(string Sorting_Order, string Search_Data)
        {
            ViewBag.SortingFirstName = String.IsNullOrEmpty(Sorting_Order) ? "First_Name_Description" : "";
            ViewBag.SortingLastName = Sorting_Order == "Last_Name_Asc" ? "Last_Name_Desc" : "Last_Name_Asc";
            ViewBag.SortingAge = Sorting_Order == "Age_Asc" ? "Age_Desc" : "Age_Asc";
            ViewBag.SortingGender = Sorting_Order == "Gender_Asc" ? "Gender_Desc" : "Gender_Asc";
            string sort = "";
            string asc = "&#x25BE;";
            string desc = "&#x25B4;";
            string ascOrDesc;
            var sims = from sim in _simBusiness.AllSims() select sim;
            if (!String.IsNullOrEmpty(Search_Data))
            {
                sims = sims.Where(sim => sim.FirstName.ToUpper().Contains(Search_Data.ToUpper())
                    || sim.LastName.ToUpper().Contains(Search_Data.ToUpper()));
            }
            //if (!String.IsNullOrEmpty(Search_Data))
            //{
            //    sims = sims.Where(sim => sim.FirstName.Contains(Search_Data));
            //}

            switch (Sorting_Order)
            {
                case "First_Name_Description":
                    sims = sims.OrderByDescending(sim => sim.FirstName);
                    ascOrDesc = desc;
                    sort = "firstname";
                    break;
                case "Last_Name_Desc":
                    sims = sims.OrderByDescending(sim => sim.LastName);
                    ascOrDesc = desc;
                    sort = "lastname";
                    break;
                case "Last_Name_Asc":
                    sims = sims.OrderBy(sim => sim.LastName);
                    ascOrDesc = asc;
                    sort = "lastname";
                    break;
                case "Age_Desc":
                    sims = sims.OrderByDescending(sim => sim.Age);
                    ascOrDesc = desc;
                    sort = "age";
                    break;
                case "Age_Asc":
                    sims = sims.OrderBy(sim => sim.Age);
                    ascOrDesc = asc;
                    sort = "age";
                    break;
                case "Gender_Desc":
                    sims = sims.OrderByDescending(sim => sim.Gender);
                    ascOrDesc = desc;
                    sort = "gender";
                    break;
                case "Gender_Asc":
                    sims = sims.OrderBy(sim => sim.Gender);
                    ascOrDesc = asc;
                    sort = "gender";
                    break;
                default:
                    sims = sims.OrderBy(sim => sim.FirstName);
                    ascOrDesc = asc;
                    sort = "firstname";
                    break;
            }
            switch (sort)
            {
                case "firstname":
                    ViewBag.SortedFirstName = ascOrDesc;
                    ViewBag.SortedLastName = "";
                    ViewBag.SortedAge = "";
                    ViewBag.SortedGender = "";
                    break;
                case "lastname":
                    ViewBag.SortedFirstName = "";
                    ViewBag.SortedLastName = ascOrDesc;
                    ViewBag.SortedAge = "";
                    ViewBag.SortedGender = "";
                    break;
                case "age":
                    ViewBag.SortedFirstName = "";
                    ViewBag.SortedLastName = "";
                    ViewBag.SortedAge = ascOrDesc;
                    ViewBag.SortedGender = "";
                    break;
                case "gender":
                    ViewBag.SortedFirstName = "";
                    ViewBag.SortedLastName = "";
                    ViewBag.SortedAge = "";
                    ViewBag.SortedGender = ascOrDesc;
                    break;
                default:
                    break;
            }
            return View(sims);
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
        static T RandomEnumValue<T>(Random rand)
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(rand.Next(v.Length));
        }
        static T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(new Random().Next(v.Length));
        }
        // GET: Sim/Create
        public ActionResult Create()
        {
            Sim sim = new Sim();
            var rand1 = new Random();
            for (int i = 1; i < 4; i++)
            {
                switch (i)
                {
                    case 1:
                        //var rand1 = new Random(Guid.NewGuid().GetHashCode());
                        sim.Trait1 = RandomEnumValue<Sim.PersonalityTrait>(rand1);
                        break;
                    case 2:
                        //var rand2 = new Random(Guid.NewGuid().GetHashCode());
                        sim.Trait2 = RandomEnumValue<Sim.PersonalityTrait>(rand1);
                        break;
                    case 3:
                        //var rand3 = new Random(Guid.NewGuid().GetHashCode());
                        sim.Trait3 = RandomEnumValue<Sim.PersonalityTrait>(rand1);
                        break;
                    default:
                        break;
                }
            }
            sim.Age = RandomEnumValue<Sim.AgeCategory>();
            sim.Gender = RandomEnumValue<Sim.GenderType>();
            sim.Aspiration = RandomEnumValue<Sim.AspirationType>();
            sim.ImageFileName = "default.png";
            return View(sim);
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
