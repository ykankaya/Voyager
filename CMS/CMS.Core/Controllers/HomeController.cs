﻿using CMS.Core.DAL;
using CMS.Core.Models;
using CMS.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Core.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IDatabaseContext db)
        {
            db.Set<ConfigModel>().Add(new ConfigModel() { Key = "x", Value = "y" });
            db.Save();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}