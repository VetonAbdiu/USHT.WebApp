using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace USHT.WebApp.Controllers
{
    public class ProfessorsController : Controller
    {
        // GET: Professors
        public ActionResult Index()
        {
            return View();
        }

        // GET: Professors/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Professors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Professors/Create
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

        // GET: Professors/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Professors/Edit/5
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

        // GET: Professors/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Professors/Delete/5
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
