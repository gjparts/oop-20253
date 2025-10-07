using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AsociacionClases
{
    public class Operador
    {
        //Propiedades
        public String Nombre { get; set; }
        public String Pais { get; set; }
        //Constructor
        public Operador(String nombre, String pais)
        {
            this.Nombre = nombre;
            this.Pais = pais;
        }
    }
}
