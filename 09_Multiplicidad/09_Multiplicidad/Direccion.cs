using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Multiplicidad
{
    public class Direccion
    {
        //Campos privados
        private Barrio _colonia;

        //Propiedades
        public Barrio Colonia
        {
            get => this._colonia;
            set
            {
                if (value == null) //Asoc. por composicion
                    throw new ArgumentException("Colonia en Direccion no puede ser null");
                else
                    this._colonia = value; //Se acepta
            }
        }
        public String Calle { get; set; }
        public String Avenida { get; set; }
        public String Bloque { get; set; }
        public String Casa { get; set; }


        //Constructor
        public Direccion(Barrio colonia)
        {
            this.Colonia = colonia;
        }
    }
}
