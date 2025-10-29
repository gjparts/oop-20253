using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Herencia2
{
    public class File
    {
        //Propiedades
        public String Name {  get; set; }
        public int Size { get; set; }
        public String Type { get; }
        public String Extension { get; set; }
        public DateTime CreationDate { get; set; }

        //Constructor
        public File(String name, int size, String type, String extension, DateTime creationDate)
        {
            this.Name = name;
            this.Size = size;
            this.Type = type;
            this.Extension = extension;
            this.CreationDate = creationDate;
        }

        //Metodos
        public void Print()
        {
            Console.WriteLine("*************** FILE ***************");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Size in bytes: {this.Size}");
            Console.WriteLine($"Type: {this.Type}");
            Console.WriteLine($"Extension: {this.Extension}");
            Console.WriteLine($"CreationDate: {this.CreationDate.ToShortDateString()}");
        }
    }
}
