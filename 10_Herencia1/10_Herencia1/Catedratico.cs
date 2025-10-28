using _10_Herencia1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Herencia1
{
    public class Catedratico : Empleado
    {
        //Propiedades
        public String Profesion {  get; set; }

        //Constructor
        public Catedratico(String nombre, int edad, Genero genero, float salario, String profesion)
            :base(nombre,edad,genero,salario,"Docente") //Construir la clase Padre Empleado
        {
            this.Profesion = profesion;
        }

        //Metodos
        public void Educar()
        {
            Console.WriteLine($"Doy clases sobre {this.Profesion}");
        }
    }
}
