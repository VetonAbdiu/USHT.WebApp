using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace USHT.WebApp.Controllers
{
    public class FacultiesController : Controller
    {
        // GET: Faculties
        public ActionResult Index()
        {
            return View();
        }

        // GET: Faculties/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Faculties/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Faculties/Create
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

        // GET: Faculties/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Faculties/Edit/5
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

        // GET: Faculties/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Faculties/Delete/5
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
