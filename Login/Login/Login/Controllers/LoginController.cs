//https://www.youtube.com/watch?v=I36SfEBfKD8&ab_channel=CodeGalaxy

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Models;

namespace Login.Controllers
{
    public class LoginController : Controller
    {
        EmployeeEntities db=new EmployeeEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Auth(Login.Models.Login login)
        {
            var cnt=db.Logins.Where(x=>x.uid==login.uid && x.pwd==login.pwd).Count();
            if (cnt>0)
            {
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }

        public ActionResult Dashboard()
        {
            return View();
        }
    }
}