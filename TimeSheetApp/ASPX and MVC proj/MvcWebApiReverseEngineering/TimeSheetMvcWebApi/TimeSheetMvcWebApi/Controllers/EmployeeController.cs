using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TimeSheetMvcWebApi.Models;

namespace TimeSheetMvcWebApi.Controllers
{
    
    public class EmployeeController : ApiController
    {

        Model1 context = new Model1();
        // GET api/employee
        public IEnumerable<EMPLOYEE> Get()
        {         
          var employees = context.EMPLOYEEs.ToList();
            
           //return userTime
            return employees;
            //return new string[] { "value1", "value2" };

        }

        // GET api/employee/5
        public EMPLOYEE Get(int id)
        {
            var emp = context.EMPLOYEEs.FirstOrDefault(p=>p.EMPID==id);

            
            return emp;
        }

        // POST api/employee
        public void Post([FromBody]string value)
        {
            var emp = new EMPLOYEE
            {
                ACTIVE = true,
                NAME = "Newtest",
                CREATEDBY = 2,
                CREATEDDATE = System.DateTime.Now,
                LASTUPDATEDBY = 1,
        };
                        
            context.EMPLOYEEs.Add(emp);
            context.SaveChanges();
        }

        // PUT api/employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/employee/5
        public void Delete(int id)
        {
        }
    }
}
