using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polimorfismo1
{
    public class Perro : Animal
    {
        //Propiedades
        public String Apodo { get; set; }
        public String Raza { get; set; }

        //Constructor
        public Perro(String apodo, String raza, bool tieneCola)
            : base("Perro","Canino",4,tieneCola) //construir la super clase
        {
            this.Apodo = apodo;
            this.Raza = raza;
        }

        //Metodos
        public void Jugar()
        {
            Console.WriteLine("El perro corre para todos lados y ladra de felicidad.");
        }
        //Polimorfismo:
        public override void Hablar()
        {
            //override completo
            Console.WriteLine("guau guau");
        }
        public override void Imprimir()
        {
            //override parcial
            base.Imprimir();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Apodo: {this.Apodo}");
            Console.WriteLine($"Raza: {this.Raza}");
            Console.ResetColor();
        }
    }
}
