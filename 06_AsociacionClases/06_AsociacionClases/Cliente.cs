using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_AsociacionClases
{
    public class Cliente
    {
        //Propiedades
        public String Nombre { get; set; }
        public String Rtn { get; set; }
        public String Telefono { get; set; }
        public String Correo { get; set; }

        //Constructor
        public Cliente(String nombre, String rtn, String telefono, String correo)
        {
            this.Nombre = nombre;
            this.Rtn = rtn;
            this.Telefono = telefono;
            this.Correo = correo;
        }
    }
}
