using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AsociacionClases
{
    public class Empresa
    {
        //Campos privados
        private Direccion _direccion;

        //Propiedades
        public String Nombre;
        public String Rubro;
        public Direccion Direccion
        {
            get => this._direccion;
            set
            {
                if( value == null ) //asoc. por composicion
                    throw new ArgumentException( "Direccion en Empresa no puede ser null" );
                else
                    this._direccion = value; //se acepta
            }
        }
        public String Telefono { get; set; }
        
        //Constructor
        public Empresa(String nombre, String rubro, Direccion direccion, String telefono)
        {
            this.Nombre = nombre;
            this.Rubro = rubro;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
    }
}
