using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VertragsLibrary;

namespace MyWebAPI.Controllers
{
    public class VertragController : ApiController
    {   
        Vertrag v1 = new Vertrag();
     

        // GET: api/Vertrag
        public Vertrag Get()
        {
            v1.Versicherungsnehmer.Vorname = "Franz";
            v1.Versicherungsnehmer.Nachname = "Buchner";

            //Versicherte Person hinzufügen
            VersichertePerson p1 = new VersichertePerson();          
            p1.Vorname = "Versicherte Person Nr1";
            v1.VersichertePersonen.Add(p1);
           
            return v1;
        }

        // GET: api/Vertrag/5
        public string Get(int id)
        {
            return "value";
        }

        //// POST: api/Vertrag
        public void Post([FromBody]string value)
        {
        }



        // PUT: api/Vertrag/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Vertrag/5
        public void Delete(int id)
        {
        }
    }
}
