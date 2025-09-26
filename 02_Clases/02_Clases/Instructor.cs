using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Clases.Enums;

namespace _02_Clases
{
    public class Instructor
    {
        //Campos privados
        private int _edad;

        //Propiedades
        public String Nombre { get; set; }
        public int Edad
        {
            get => this._edad;
            set
            {
                if (value >= 18)
                    this._edad = value; //se acepta
                else
                    throw new ArgumentException("Edad debe ser >= 18");
            }
        }
        public Genero Genero { get; set; }
        public TipoContrato TipoContrato { get; set; }
        public TipoInstructor TipoInstructor { get; set; }
    }
}
