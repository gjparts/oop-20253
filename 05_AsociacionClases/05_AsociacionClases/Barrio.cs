using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AsociacionClases
{
    public class Barrio
    {
        //Propiedades
        public String Nombre { get; set; }
        public String Pais { get; set; }
        public String Municipio { get; set; }
        public String Ciudad { get; set; }
        
        //Constructor
        public Barrio(string nombre, string pais, string municipio, string ciudad)
        {
            this.Nombre = nombre;
            this.Pais = pais;
            this.Municipio = municipio;
            this.Ciudad = ciudad;
        }
    }
}
