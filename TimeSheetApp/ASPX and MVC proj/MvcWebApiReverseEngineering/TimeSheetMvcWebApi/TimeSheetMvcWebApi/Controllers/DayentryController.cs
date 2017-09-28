using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TimeSheetMvcWebApi.Models;

namespace TimeSheetMvcWebApi.Controllers
{
    public class DayentryController : ApiController
    {

        Model1 context = new Model1();
        // GET api/dayentry
        public IEnumerable<DAYENTRY> Get()
        {
            var dayentry = context.DAYENTRies.ToList();
            return dayentry;

            //return new string[] { "value1", "value2" };
        }

        // GET api/dayentry/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/dayentry
        public void Post([FromBody]string value)
        {
        }

        // PUT api/dayentry/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/dayentry/5
        public void Delete(int id)
        {
        }
    }
}
