using Assignment2.Data;
using Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using static Assignment2.Models.Car;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        private Assignment2Context db = new Assignment2Context();

        public ActionResult Index()
        {
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

        public ActionResult Car_List()
        {
            var cars = db.Cars.ToList();
            return View(cars);
           
        }

        public ActionResult Car_Info(int? id)
        {
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Car car = db.Cars.Find(id);
                if (car == null)
                {
                    return HttpNotFound();
                }
                return View(car);
            }
        }


    }

}