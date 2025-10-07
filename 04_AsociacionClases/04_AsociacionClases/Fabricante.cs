using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AsociacionClases
{
    public class Fabricante
    {
        //Propiedades
        public String Nombre { get; set; }
        public String Pais { get; set; }
        public String Contacto { get; set; }
        //Constructor
        public Fabricante(String nombre, String pais, String contacto)
        {
            this.Nombre = nombre;
            this.Pais = pais;
            this.Contacto = contacto;
        }
    }
}
