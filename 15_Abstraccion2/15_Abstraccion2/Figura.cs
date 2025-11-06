using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Abstraccion2
{
    public abstract class Figura
    {
        //Propiedades
        public String Nombre { get; } //solo se puede inicializar desde el constructor

        //Constructor
        public Figura(String nombre)
        {
            this.Nombre = nombre;
        }

        //Metodos abstractos
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }
}
