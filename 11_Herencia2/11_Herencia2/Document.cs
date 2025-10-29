using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Herencia2
{
    public class Document : File
    {
        //Propiedades
        public Author Author { get; set; }
        public DateTime ModificationDate { get; set; }
        public int Words { get; set; }

        //Constructor
        public Document(String name, int size, String extension, DateTime creationDate,
            Author author, DateTime modificationDate, int words)
            :base(name,size,"Document File",extension,creationDate) //construir la clase padre
        {
            //Propiedades de esta clase:
            this.Author = author;
            this.ModificationDate = modificationDate;
            this.Words = words;
        }
    }
}
