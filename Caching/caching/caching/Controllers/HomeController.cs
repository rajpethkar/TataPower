//https://www.youtube.com/watch?v=-6NpzXhDXKI&ab_channel=YogeshSharma

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace caching.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [OutputCache(Duration=5,Location =System.Web.UI.OutputCacheLocation.Any,NoStore =true,VaryByParam ="none")]
        public ActionResult Index()
        {
            return Content("Date:"+ DateTime.Now.ToLongTimeString());
        }
        [OutputCache(Duration = 5, Location = System.Web.UI.OutputCacheLocation.Any, NoStore = true, VaryByParam = "none")]
        public ActionResult GetEmp(int id)
        {
            return Content("Date:" + DateTime.Now.ToLongTimeString()+" id:"+id);
        }
        [OutputCache(CacheProfile ="Admin")]
        public ActionResult GetEmp2()
        {
            return Content("Date:" + DateTime.Now.ToLongTimeString());
        }
    }
}