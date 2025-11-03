using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polimorfismo2
{
    public class Subtitle
    {
        //Propiedades
        public String Language { get; set; }
        public Author Author { get; set; }

        //Constructor
        public Subtitle(String language, Author author)
        {
            this.Language = language;
            this.Author = author;
        }
    }
}
