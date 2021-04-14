using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SurveyManagementSystem.Models;

namespace SurveyManagementSystem.Controllers
{
    public class RegisterController: Controller
    {
        private readonly ConnectionStringClass _cc;
        public RegisterController(ConnectionStringClass cc)
        {
            _cc = cc;

        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Survey sc)
        {
            _cc.Add(sc);
            _cc.SaveChanges();
            ViewBag.message = "The Record is saved successfully";
            return View();

        }
    }
}
