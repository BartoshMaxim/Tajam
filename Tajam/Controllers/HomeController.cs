﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tajam.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View("Index");
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Expertise()
        {
            return View();
        }

        public ActionResult Teams()
        {
            return View();
        }

        public ActionResult Works()
        {
            return View();
        }

        public ActionResult Testimonials()
        {
            return View();
        }
    }
}