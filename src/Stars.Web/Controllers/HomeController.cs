﻿using Stars.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stars.Web.Controllers
{
    public class HomeController : Controller
    {
        private IStarsDataSource _db;

        public HomeController(IStarsDataSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View(_db.Clients);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}