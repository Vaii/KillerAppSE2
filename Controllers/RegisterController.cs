﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KillerAppSE2.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Ouder()
        {
            return View();
        }

        public ActionResult Student()
        {
            return View();
        }

        [HttpPost]

    }
}