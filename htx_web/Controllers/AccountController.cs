using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace htx.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        //public ActionResult Validate(Admins admin)
        //{
        //    var _admin = db.Admins.Where(s => s.Email == admin.Email);
        //    if (_admin.Any())
        //    {
        //        if (_admin.Where(s => s.Password == admin.Password).Any())
        //        {

        //            return Json(new { status = true, message = "Login Successfull!" });
        //        }
        //        else
        //        {
        //            return Json(new { status = true, message = "Invalid Password!" });
        //        }
        //    }
        //    else
        //    {
        //        return Json(new { status = false, message = "Invalid Email!" });
        //    }
        //}
    }
}