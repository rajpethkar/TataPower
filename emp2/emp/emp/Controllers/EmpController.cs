//https://www.youtube.com/watch?v=PQF2x2iFUag&ab_channel=LogicTycoon

using emp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace emp.Controllers
{
    public class EmpController : Controller
    {
        EmployeeEntities db = new EmployeeEntities();
        public ActionResult Index(emp.Models.emp obj)
        {
            if (obj != null)
            {
                return View(obj);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult AddEmplyoee(emp.Models.emp model)
        {
            if (ModelState.IsValid)
            {
                emp.Models.emp obj = new emp.Models.emp();
                obj.name = model.name;
                db.emps.Add(obj);
                db.SaveChanges();
                ModelState.Clear();
            }

            return View("EmpList");
           // return RedirectToAction("EmpList");
        }
        

        public ActionResult Delete(int id)
        {
            var res = db.emps.Where(x => x.id == id).First();
            db.emps.Remove(res);
            db.SaveChanges();

           var list=db.emps.ToList();

            return View("EmpList",list);
        }

        public ActionResult EmpList()
        {
            var res = db.emps.ToList();
            return View(res);
        }

    }
}