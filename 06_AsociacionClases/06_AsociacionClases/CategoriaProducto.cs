using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_AsociacionClases
{
    public class CategoriaProducto
    {
        //Propiedades
        public String Nombre {  get; set; }
        public String Pasillo { get; set; }

        //Constructor
        public CategoriaProducto(String nombre, String pasillo)
        {
            this.Nombre = nombre;
            this.Pasillo = pasillo;
        }
    }
}
