using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Multiplicidad
{
    public class Empresa
    {
        //Campos privados
        private Direccion _direccion;

        //Propiedades
        public String Nombre { get; set; }
        public Direccion Direccion
        {
            get => this._direccion;
            set
            {
                if( value == null ) //Asoc. por composicion
                    throw new ArgumentException( "Direccion en Empresa no puede ser null" );
                else
                    this._direccion = value; //Se acepta
            }
        }
        public String Telefono { get; set; }

        //Constructor
        public Empresa(String nombre, Direccion direccion, String telefono)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
    }
}
