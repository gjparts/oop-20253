using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AsociacionClases
{
    public class Direccion
    {
        //Campos privados
        private Barrio _barrio;

        //Propiedades
        public Barrio Barrio
        {
            get => this._barrio;
            set
            {
                if (value == null) //asoc. por composicion
                    throw new ArgumentException("Barrio en Direccion no puede ser null");
                else
                    this._barrio = value; //se acepta
            }
        }
        public String Calle {  get; set; }
        public String Avenida { get; set; }
        public String Casa { get; set; }

        //Constructor
        public Direccion(Barrio barrio, String calle, String avenida, String casa)
        {
            this.Barrio = barrio;
            this.Calle = calle;
            this.Avenida = avenida;
            this.Casa = casa;
        }
    }
}
