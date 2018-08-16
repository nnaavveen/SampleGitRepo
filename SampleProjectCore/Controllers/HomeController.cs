﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleProjectCore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello Project " + DateTime.Now.ToString("ddMMyyyy HH:mm:ss");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hello Project " + DateTime.Now.ToString("ddMMyyyy HH:mm:ss");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}