using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KillerAppSE2.Connector;
using KillerAppSE2.Context;
using KillerAppSE2.Models;
using KillerAppSE2.Repository;

namespace KillerAppSE2.Controllers
{
    public class LoginController : Controller
    {
        private UserRepository userRepository = new UserRepository(new SQLContextUser(new MSSQLConnector()));
        private Ouder ouder { get; set; }
        private Student student { get; set; }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            student = userRepository.LoginStudent(email, password);
            ouder = userRepository.LoginOuder(email, password);
            if (student != null)
            {
                return RedirectToAction("StudentBase", "Student");
            }
            else if (ouder != null)
            {
                return RedirectToAction("OuderBase", "Ouder");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}