using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Git2.Models;
namespace Git2.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

      [HttpGet]
      
        public ActionResult Login()
        {
            var login = new User()
            {
                Usernmae = "digitall",
                name = "mohsen"
            };
            return View(login);
        }

        [HttpPost]
        public ActionResult Login(Models.User user)
        {
            if (!this.ModelState.IsValid)
                return View("Error.cshtml");
            return View();
        }
    }
}