using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Abstraccion2
{
    public class Rectangulo : Figura
    {
        //Propiedades
        public double Largo { get; set; }
        public double Ancho { get; set; }

        //Constructor
        public Rectangulo(double largo, double ancho) : base ("Rectangulo")
        {
            this.Largo = largo;
            this.Ancho = ancho;
        }
        //Metodos
        //Implementacion de metodos abstractos
        public override double CalcularArea()
        {
            return this.Largo * this.Ancho;
        }
        public override double CalcularPerimetro()
        {
            return 2 * this.Largo + 2 * this.Ancho;
        }
    }
}
