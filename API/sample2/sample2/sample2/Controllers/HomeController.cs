//https://www.youtube.com/watch?v=TbL1UdfwWWI&ab_channel=PravinUgalmugale

using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using sample2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Results;


namespace sample2.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Index()
        {


            return Ok(new { EmpName = "Rajesh" });
        }

        //[HttpPost]
        //public void AddEmp([FromBody] string value)
        //{

        //}

        [HttpPost]
        public IHttpActionResult AddEmp(Employee req)
        {
            var json = JsonConvert.SerializeObject(req);
            return Ok(json);
        }

        [HttpPut]
        public IHttpActionResult EditEmp(Employee req)
        {
            var json = JsonConvert.SerializeObject(req);
            return Ok(json);
        }

        [HttpDelete]
        public IHttpActionResult DeleteEmp(int id)
        {

            return Ok();
        }

    }
}
