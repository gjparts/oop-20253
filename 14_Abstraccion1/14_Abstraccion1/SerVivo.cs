using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Abstraccion1
{
    public abstract class SerVivo  //clase abstracta
    {
        //Propiedades
        public String Especie { get; } //en este ejemplo Especie solo se escribe en el constructor

        //Constructor
        public SerVivo(String especie)
        {
            this.Especie = especie;
        }

        //Metodos
        //Metodos abstractos (prototipos de funcion)
        public abstract void Hablar();
        public abstract void Desplazarse ();
        public abstract void Alimentarse();
        public abstract void Dormir();

        //Metodos concretos (aquellos que no son abstractos)
        public void Vivir()
        {
            //en etse caso hare que Vivir dependa de los metodos abstractos
            this.Hablar();
            this.Alimentarse();
            this.Desplazarse();
            this.Dormir();
        }
    }
}
