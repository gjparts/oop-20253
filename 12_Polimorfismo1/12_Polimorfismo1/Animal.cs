using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polimorfismo1
{
    public class Animal
    {
        //Propiedades
        public String Nombre { get; set; }
        public String Especie { get; set; }
        public int Patas { get; set; }
        public bool TieneCola { get; set; }

        //Constructor
        public Animal(String nombre, String especie, int patas, bool tieneCola)
        {
            this.Nombre = nombre;
            this.Especie = especie;
            this.Patas = patas;
            this.TieneCola = tieneCola;
        }

        //Metodos
        //Si desea que a un metodo se le pueda aplicar Polimorfismo se le antepone
        //la clausula virtual
        public virtual void Imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------ Animal ------------");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Especie: {this.Especie}");
            Console.WriteLine($"Número de patas: {this.Patas}");
            Console.WriteLine($"Tiene cola: { ( this.TieneCola == true ? "Si" : "No" ) }");
            Console.ResetColor();
        }
        public virtual void Hablar()
        {
            Console.WriteLine($"{this.Nombre} se está comunicando.");
        }
    }
}
