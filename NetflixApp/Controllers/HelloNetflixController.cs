﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetflixApp.Controllers
{
    public class HelloNetflixController : Controller
    {
        // GET: HelloNetflix
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Welcome(string name, int ID = 1)
        //{
            
        //    return Content("Hello " + name + " Number of times = " + ID);
        //}
     
        public ActionResult Welcome(string name, int ID = 1)
        {
            
                ViewBag.Message = "Hello" + name;
                ViewBag.NumTimes = ID;
                          
            return View();
        }

        [Route("HelloNetflix/released/{year: range(2015,2016)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "-" + month);
        }
    }
}