using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Polimorfismo2
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

        //Metodos
        public override void Print()
        {
            base.Print(); //override parcial
            //Author puede llegar a ser null (agregacion) si es asi no lo imprima
            if( this.Author != null )
                Console.WriteLine($"Author: {this.Author.Name}");
            
            Console.WriteLine($"Duration: {this.Duration}");
        }
    }
}
