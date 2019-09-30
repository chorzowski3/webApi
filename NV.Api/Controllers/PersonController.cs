using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NV.Api;
using NV.Model;

namespace NV.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private GenericUnitOfWork uow = null;
        public PersonController()
        {
            uow = new GenericUnitOfWork();
        }
        public PersonController(GenericUnitOfWork _uow)
        {
            this.uow = _uow;
        }
        //[HttpGet]
        //public ActionResult<Person> Details(int id)
        //{
        //    Person person = uow.Repository<Person>().GetDetail(p => p.BusinessEntityID == id);
        //    //if (person == null)
        //    //    return HttpNotFound();
        //    return person;
        //}

        [HttpGet]
        public ActionResult<Person> Details(int id)
        {
            Person p = new Person { BusinessEntityID = 1, FirstName = "AB", LastName = "CD" };
            return p;
        }
    }
}
