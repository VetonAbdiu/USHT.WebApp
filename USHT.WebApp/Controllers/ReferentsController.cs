using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace USHT.WebApp.Controllers
{
    public class ReferentsController : Controller
    {
        // GET: Referents
        public ActionResult Index()
        {
            return View();
        }

        // GET: Referents/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Referents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Referents/Create
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

        // GET: Referents/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Referents/Edit/5
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

        // GET: Referents/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Referents/Delete/5
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
