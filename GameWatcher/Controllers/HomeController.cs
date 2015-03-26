﻿using GameWatcher.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameWatcher.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "These games are on tap for today:";

            return View();
        }

        public ActionResult Contact()
        {
           
            return View();
        }
    }
}