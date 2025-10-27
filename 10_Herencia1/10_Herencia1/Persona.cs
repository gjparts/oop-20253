using _10_Herencia1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Herencia1
{
    public class Persona
    {
        //Campos privados (Fields)
        private int _edad;

        //Propiedades
        public String Nombre {  get; set; }
        public int Edad
        {
            get => this._edad;
            set
            {
                if (value >= 0)
                    this._edad = value; //se acepta
                else
                    throw new ArgumentException("Edad en Persona debe de ser >= 0");
            }
        }
        public Genero Genero { get; set; }

        //Constructor
        public Persona(String nombre, int edad, Genero genero)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
        }

        //Metodos
        public void Saludar()
        {
            Console.WriteLine($"Hola me llamo {this.Nombre}");
        }
    }
}
