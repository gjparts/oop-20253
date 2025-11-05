using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Abstraccion1
{
    public class Humano : SerVivo
    {
        //Propiedades
        public String Nombre { get; set; }

        //Constructor
        public Humano(String nombre) : base("Homo Sapiens") //construir la super clase
        {
            this.Nombre = nombre;
        }

        //Metodos
        //Implementacion de metodos abstractos
        public override void Dormir()
        {
            Console.WriteLine("Busca un lugar seguro y se duerme");
        }
        public override void Alimentarse()
        {
            Console.WriteLine("Come de todo tipo de comida");
        }
        public override void Hablar()
        {
            Console.WriteLine("Hola");
        }
        public override void Desplazarse()
        {
            Console.WriteLine("Camina de forma humana");
        }
    }
}
