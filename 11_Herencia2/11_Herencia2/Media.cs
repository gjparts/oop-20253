using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Herencia2
{
    public class Media : File
    {
        //Propiedades
        public Author Author { get; set; }
        public int Duration { get; set; }

        //Constructor
        public Media(String name, int size, String extension, DateTime creationDate,
            Author author, int duration)
            : base(name,size,"Media File",extension,creationDate)
        {
            this.Author = author;
            this.Duration = duration;
        }
    }
}
