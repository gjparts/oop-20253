namespace _12_Polimorfismo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("Hipopotamo", "Mamifero", 4, true);
            a1.Imprimir();
            a1.Hablar();

            Gato g1 = new Gato("Tinieblo", true, true);
            g1.Imprimir();
            g1.Hablar();
            g1.Ronronear();

            Perro p1 = new Perro("Killer", "Doberman", false);
            p1.Imprimir();
            p1.Hablar();
            p1.Jugar();

            Console.WriteLine("-------------------------------");
            /*en C# toda clase hereda quieran o no de la clase Object
             esta clase tiene varios metodos que son virtual o sea que se les
            puede hacer polimorfismo. Uno de los mas famosos es toString()*/
            Console.WriteLine(g1.ToString());
            Console.WriteLine(p1.ToString());
            //Observe que para g1 que es Gato hicimos override a toSTring()
            //en cambio para p1 que es Perro no hay toString() personalizado
            Console.WriteLine(g1);
            Console.WriteLine(p1);
            //en C# si imprime un objeto sin determinar alguna de sus propiedades
            //entonces lo que se va a imprimir es el resultado de toString()
        }
    }
}
