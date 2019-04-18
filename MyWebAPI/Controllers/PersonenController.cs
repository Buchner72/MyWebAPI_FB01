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
        IList<PersonN> personen = new List<PersonN>() {
                new PersonN(){ Id=1, Vorname="Bill", Nachname="Haier"},
                new PersonN(){ Id=2, Vorname="Steve", Nachname="Huemer"},
                new PersonN(){ Id=3, Vorname="Ram", Nachname="Klarres"},
                new PersonN(){ Id=4, Vorname="Moin", Nachname="Laimer"}
            };

        [HttpGet]
        //Besser wäre angeblich Puplic List<PersonN>
        public IEnumerable<PersonN> Get()
        {         
            return personen;
        }


        public PersonN Get(int id)
      //  public IHttpActionResult Get(int id)
        {

            return personen.Where(x => x.Id == id).FirstOrDefault();
            //foreach (var p in personen)
            //{
            //    if (id==p.Id)
            //    {
            //        return Ok(p);
            //    }                   
            //}
            //return BadRequest();
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] PersonN person)
        {
            int Id = personen.Count + 1;
            person.Id = Id;
            personen.Add(person);

            return Ok(person);
        }

        [HttpPut]
        public IHttpActionResult Put(int id,[FromBody] PersonN person)
        {
            return Ok(person);
        }


    }
}
