namespace _14_Abstraccion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //una clase abstracta no puede ser instanciada de manera tradicional
            //SerVivo s = new SerVivo("Felino");

            Gato g1 = new Gato("Misifus");
            g1.Vivir();
            Console.WriteLine("------------------------------------");
            Humano h1 = new Humano("Gerardo Portillo");
            h1.Vivir();

            //Otra ventaja de usar clases abstractas es que al tener metodos
            //similares se puede declarar un objeto que herede de una clase
            //abstracta y apuntarlo a otro objeto que herede de la misma clases abstracta
            //sin problema:
            //SerVivo se puede instanciar a una clase compatible:
            SerVivo s1 = new Humano("Mario Bros");
            SerVivo s2 = new Gato("Naranjoso");

            Console.WriteLine("--------------------------");
            s1.Vivir();
            Console.WriteLine("--------------------------");
            s2.Vivir();

            //recuerdan la clase Math?
            double numero = Math.Pow(5,2);
            //esto se debe a que los metodos como Pow, Sqrt, Abs, y demas dentro de Math
            //son metodos estáticos (patrón Singleton)
            //Vamos a crear un par de metodos estaticos en SerVivo y los vamos a usar aqui:
            Console.WriteLine("-----------------------------------");
            SerVivo.Algo();
            Console.WriteLine(SerVivo.Sumar(7,8));
            //observe que usamos Algo() y Sumar() sin necesidad de instanciar un nuevo objeto

            //Prueba del metodo de instanciacion para SerVivo.
            Console.WriteLine("-----------------------------------");
            SerVivo s3 = SerVivo.getInstance();
            s3.Vivir();
        }
    }
}
