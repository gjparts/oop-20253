using _10_Herencia1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Herencia1
{
    public class Empleado : Persona //Herencia
    {
        //Propiedades
        public float Salario {  get; set; }
        public String Cargo { get; set; }

        //Constructores
        /*Observe que en este caso decidí construir la clase Empleado con un constructor
         sin parametros; pero siempre estoy obligado a construir la clase padre, si no tengo
        con que llenar el constructor de la clase padre; entonces uso valores predeterminados genericos*/
        public Empleado() : base("No tiene", 0, Enums.Genero.Otros)
        {
            this.Salario = 0;
            this.Cargo = "No definido";
        }
        //Tambien puede tener el clasico constructor con parametros
        public Empleado(String nombre, int edad, Genero genero, float salario, String cargo)
            : base(nombre, edad, genero)
        {
            this.Salario = salario;
            this.Cargo = cargo;
        }
        //Observe que en ambos constructores debo construir la super clase (base)

        public void Trabajar()
        {
            Console.WriteLine($"Estoy trabajando en el cargo de {this.Cargo}");
            Console.WriteLine($"Mi edad es {this.Edad}");
        }
    }
}
