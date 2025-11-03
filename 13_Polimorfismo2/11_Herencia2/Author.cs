using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polimorfismo2
{
    public class Author
    {
        //Propiedades
        public String Name { get; set; }
        public String Website { get; set; }
        public String EMail { get; set; }

        //Constructor
        public Author(String name, String website, String email)
        {
            this.Name = name;
            this.Website = website;
            this.EMail = email;
        }
    }
}
