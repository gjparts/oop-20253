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

        /*Metodos Estaticos: son aquellos que se pueden usar sin necesidad de instanciar
         un nuevo objeto de esta clase. Siempre son static porque esto indica que van a estar
        disponibles en la definicion de la clase.*/
        public static void Algo()
        {
            Console.WriteLine("Hola soy un metodo estatico de prueba");
        }
        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        /*En toda clase abstracta se recomienda tener un:
         * Metodo de instanciación
         * es un metodo que permite crear un objeto para la clase abstracta el cual
         * se basa en un objeto compatible con ella.
         * No todas las clases abstractas tienen este metodo; pero se recomienda ponerlo.
         * Normalmente se le nombra como getInstance y su tipo de dato es la propia clase abstracta
         * */
        public static SerVivo getInstance()
        {
            //retornar un objeto de una clase compatible con SerVivo:
            return new Humano("sin nombre");
        }
    }
}
