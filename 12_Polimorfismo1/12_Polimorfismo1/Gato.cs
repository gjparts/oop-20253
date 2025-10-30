using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Polimorfismo1
{
    public class Gato : Animal
    {
        //Propiedades
        public String Apodo { get; set; }
        public bool TienePelaje { get; set; }

        //Constructor
        public Gato(String apodo, bool tienePelaje, bool tieneCola)
            : base("Gato", "Felino", 4, tieneCola)
        {
            this.Apodo = apodo;
            this.TienePelaje = tienePelaje;
        }

        //Metodos
        public void Ronronear()
        {
            Console.WriteLine("Prrrrrrrrrrrrrrr");
        }
        //Polimorfismo: cambiar la respuesta para un metodo heredado
        //se usa la clausa override cuando el metodo es virtual en la clase padre
        //para hacer polimorfismo debe usarse la misma firma que tiene el metodo en la
        //clase padre.
        public override void Hablar()
        {
            //Override completo: no se reutiliza nada del metodo heredado
            //lo que cambia por completo su comportamiento.
            Console.WriteLine("Miau");
        }
        public override void Imprimir()
        {
            //Override parcial: reutiliza codigo del metodo heredado, lo que permite
            //expandir su funcionalidad.
            base.Imprimir(); //mandar a llamar el metodo heredado de la clase padre
            //ejecutamos las expansiones o mejoras:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Apodo: {this.Apodo}");
            Console.WriteLine($"Tiene pelaje: { ( this.TienePelaje == true ? "Si" : "No" ) }");
            Console.ResetColor();
        }
    }
}
