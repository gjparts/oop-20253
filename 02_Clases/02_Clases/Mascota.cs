using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    //interal: la clase solo esta disponible para este proyecto en la solucion
    //public: la clase esta disponible en todos los proyectos de la solucion
    public class Mascota
    {
        //Propiedades
        //usen Pascal Case para nombrar sus clases, propiedades y metodos en C#
        //{ get; set; } se les conoce como accesores uno es de salida (get) y el otro de entrada (set)
        //en C# esta es la forma recomendada de utilizar el Encapsulamiento.
        public String Nombre { get; set; } //auto-implemented property (propiedad automatica)
        public String Especie { get; set; }
        public int Edad {  get; set; }
        public char Genero { get; set; }
    }
}
