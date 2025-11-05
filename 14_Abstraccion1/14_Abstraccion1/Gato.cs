using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Abstraccion1
{
    public class Gato : SerVivo
    {
        //Propiedades
        public String Apodo { get; set; }

        //Constructor
        public Gato(String apodo) : base("Felino") //construir la clase padre
        {
            this.Apodo = apodo;
        }

        //Metodos
        //Implementacion de metodos abstractos
        public override void Dormir()
        {
            Console.WriteLine("Busca un rincon oscuro y se duerme.");
        }
        public override void Alimentarse()
        {
            Console.WriteLine("Come alimentos gatunos");
        }
        public override void Hablar()
        {
            Console.WriteLine("Miau");
        }
        public override void Desplazarse()
        {
            Console.WriteLine("Camina de forna sigilosa");
        }
    }
}
