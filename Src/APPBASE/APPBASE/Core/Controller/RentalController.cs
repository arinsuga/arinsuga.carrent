using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APPBASE.Models;

namespace APPBASE.Controllers
{
    public class RentalController : Controller
    {
        protected Car oModel;

        public RentalController()
        {
            this.oModel = new Car();
        }
        public RentalController(Car parModel)
        {
            this.oModel = parModel;
        }

        // GET: Rent
        public ActionResult Index()
        {
            return View();
        }

        // GET: Rent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rent/Create
        public ActionResult Create()
        {
            return View(this.oModel);
        }

        // POST: Rent/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Rent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rent/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Rent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rent/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}