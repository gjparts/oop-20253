using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Multiplicidad
{
    public class Barrio
    {
        //Propiedades
        public String Nombre { get; set; }
        public String Zona { get; set; }
        public String CodigoPostal { get; set; }

        //Constructor
        public Barrio(String nombre, String zona, String codigoPostal)
        {
            this.Nombre = nombre;
            this.Zona = zona;
            this.CodigoPostal = codigoPostal;
        }
    }
}
