using System.Collections.Generic;

namespace MyWebAPI.Models
{
    public class Adresse
    {
        public Adresse()
        {
            Personen = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string Strasse { get; set; }
        public string Ort { get; set; }

        public virtual ICollection<Person> Personen{ get; set; } 
    }
}