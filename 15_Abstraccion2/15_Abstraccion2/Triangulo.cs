using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Abstraccion2
{
    public class Triangulo : Figura
    {
        //Propiedades
        public double Base { get; set; }
        public double Altura { get; set; }

        //Constructor
        public Triangulo(double valor_base, double altura):base("Triangulo Equilatero")
        {
            this.Base = valor_base;
            this.Altura = altura;
        }

        //Metodos
        //Implementacion de metodos abstractos
        public override double CalcularArea()
        {
            return 0.5*this.Base*this.Altura;
        }
        public override double CalcularPerimetro()
        {
            return 3*this.Base;
        }
    }
}
