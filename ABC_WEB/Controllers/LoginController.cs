using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ABC_WEB.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            try
            {

                return RedirectToAction("NewOrder", "Orders", new { status = "OK" });
            }
            catch (Exception ex)
            {
               
            }
            return View("Login");
        }
    }
}