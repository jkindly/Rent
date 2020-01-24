using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rent.Models;
using Rent.ViewModels;

namespace Rent.Controllers
{
    public class RentCarsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RentCars
        public ActionResult Index()
        {
            return View(db.RentCars.ToList());
        }

        // GET: RentCars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RentCar rentCar = db.RentCars.Find(id);
            if (rentCar == null)
            {
                return HttpNotFound();
            }
            return View(rentCar);
        }

        // GET: RentCars/Create
        public ActionResult Create()
        {
            var customers = db.Customers.ToList();
            var cars = db.Cars.ToList();

            var viewModel = new NewRentCarViewModel
            {
                Customers = customers,
                Cars = cars
            };

            return View(viewModel);
        }

        [HttpPost] 
        public ActionResult Create(NewRentCarViewModel newRentCar)
        {
            // if (!ModelState.IsValid) return View(newRentCar);

            var newRent = new RentCar
            {
                RentStarTime = newRentCar.RentCar.RentStarTime,
                RentEndTime = newRentCar.RentCar.RentEndTime,
                CarId = newRentCar.RentCar.CarId,
                CustomerId = newRentCar.RentCar.CustomerId,
                Car = newRentCar.RentCar.Car,
                Customer = newRentCar.RentCar.Customer
            };

            db.RentCars.Add(newRent);
            db.SaveChanges();

            return RedirectToAction("Index");

        }

        // GET: RentCars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RentCar rentCar = db.RentCars.Find(id);
            if (rentCar == null)
            {
                return HttpNotFound();
            }
            return View(rentCar);
        }

        // POST: RentCars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RentStarTime,RentEndTime")] RentCar rentCar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rentCar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rentCar);
        }

        // GET: RentCars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RentCar rentCar = db.RentCars.Find(id);
            if (rentCar == null)
            {
                return HttpNotFound();
            }
            return View(rentCar);
        }

        // POST: RentCars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RentCar rentCar = db.RentCars.Find(id);
            db.RentCars.Remove(rentCar);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
