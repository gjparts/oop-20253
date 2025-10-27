using _10_Herencia1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Herencia1
{
    public class Estudiante : Persona //Herencia
    {
        //Propiedades
        public String Cuenta { get; set; }
        public String Carrera { get; set; }

        //Constructor
        public Estudiante(String nombre, int edad, Genero genero, String cuenta, String carrera)
            : base(nombre, edad, genero) //Construir la super clase, clase padre o clase base
        {
            //inicializar las propiedades de la clase actual
            this.Cuenta = cuenta;
            this.Carrera = carrera;
        }
        //Metodos
        public void Estudiar()
        {
            Console.WriteLine($"Soy estudiante de {this.Carrera} y mi edad es {this.Edad}");
        }
    }
}
