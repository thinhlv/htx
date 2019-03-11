using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using htx_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace htx_web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        MyDbContext _dbContext;

        public IActionResult Login()
        {
            return View();
        }

        public LoginController(MyDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public ActionResult Validate(Admin admin)
        {
            var data = this._dbContext.Admin.Where(s => s.email == admin.email);
            if (data.Any())
            {
                if (data.Where(s => s.password == admin.password).Any())
                {

                    return Json(new { status = true, message = "Login Successfull!" });
                }
                else
                {
                    return Json(new { status = true, message = "Invalid Password!" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Invalid Email!" });
            }
        }
    }
}