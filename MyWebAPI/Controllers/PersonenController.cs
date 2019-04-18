using MyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebAPI.Controllers
{
    //  [Route("api/[controller]")]
    public class PersonenController : ApiController
    {
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return new[]
            {
                new Person
                {
                    Vorname = "Franz",
                    Nachname ="Buchner",
                    Id=1
                }
            };
        }

        public IHttpActionResult Get(int id)
        {
            Person p1 = new Person();
            p1.Vorname = "Johann";
            p1.Nachname = "Scheck";
            return Ok(p1);
            
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] Person person)
        {           
            return Ok(person);
        }

        [HttpPut]
        public IHttpActionResult Put(int id,[FromBody] Person person)
        {
            return Ok(person);
        }


    }
}
