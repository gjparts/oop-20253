using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Multiplicidad
{
    public class Mascota
    {
        //Propiedades
        public String Nombre {  get; set; }
        public String Especie { get; set; }

        //Constructor
        public Mascota(String nombre, String especie)
        {
            this.Nombre = nombre;
            this.Especie = especie;
        }
    }
}
