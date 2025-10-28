using _10_Herencia1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Herencia1
{
    public class Practicante : Empleado //Herencia
    {
        //Propiedades
        public int Meses { get; set; }

        //Constructor
        public Practicante(String nombre, int edad, Genero genero, float salario, int meses)
            :base(nombre,edad,genero,salario,"Practicante o pasante") //Construir la clase Padre
        {
            this.Meses = meses;
        }
    }
}
