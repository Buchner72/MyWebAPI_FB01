using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebAPI.Models
{
    public class PersonN
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public int AdresseId { get; set; }
        public Adresse Adresse { get; set; }
    }
}