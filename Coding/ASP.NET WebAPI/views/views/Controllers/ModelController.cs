﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace views.Controllers
{
    public class ModelController : Controller
    {
        // GET: Model
        public ActionResult Index()
        {
            return View();
        }

        // GET: Model/Details/5
        public ActionResult PartialIndex()
        {
            return View();
        }

        // GET: Model/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Model/Create
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

        // GET: Model/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Model/Edit/5
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

        // GET: Model/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Model/Delete/5
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
