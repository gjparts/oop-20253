using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Multiplicidad
{
    public class Diploma
    {
        //Propiedades
        public String Institucion { get; set; }
        public String Nombre { get; set; }

        //Constructor
        public Diploma(String institucion, String nombre)
        {
            this.Institucion = institucion;
            this.Nombre = nombre;
        }
    }
}
