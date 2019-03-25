using ClientService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClientService.Controllers
{
    public class HomeController : ApiController
    {
        List<EmpModel> emp = new List<EmpModel>() {
            new EmpModel {id = 1, name = "Rafael 01", city = "Baru"},
            new EmpModel {id = 2, name = "Rafael 02", city = "Caracas"},
            new EmpModel {id = 3, name = "Rafael 03", city = "Osasco"},
        };

        [HttpGet]
        public IEnumerable<EmpModel> Get()
        {
            return emp;
        }

        [HttpGet]
        public IEnumerable<EmpModel> Get(int id)
        {
            List<EmpModel> objList = new List<EmpModel>();
            var empList = (from a in emp where a.id.Equals(id) select new { a.id, a.name, a.city }).ToList();
            return objList;

        }

    }
}
