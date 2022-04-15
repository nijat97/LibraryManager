using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.BLL
{
    public class Author
    {
        public String name { get; set; }
        public String nationality { get; set; }
        public DateTime birthDate { get; set; }

        public Author(string name, string nationality, DateTime birthDate)
        {
            this.name = name;
            this.nationality = nationality;
            this.birthDate = birthDate;
        }
    } 
}
