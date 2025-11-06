namespace _15_Abstraccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r1 = new Rectangulo(8, 5);
            Console.WriteLine($"Nombre de r1: {r1.Nombre}");
            Console.WriteLine($"Area de r1: {r1.CalcularArea()}");
            Console.WriteLine($"Perimetro de r1: {r1.CalcularPerimetro()}");
            Console.WriteLine("----------------------------------------------");

            Circulo c1 = new Circulo(6);
            Console.WriteLine($"Nombre de c1: {c1.Nombre}");
            Console.WriteLine($"Area de c1: {c1.CalcularArea()}");
            Console.WriteLine($"Perimetro de c1: {c1.CalcularPerimetro()}");
            Console.WriteLine("----------------------------------------------");

            Triangulo t1 = new Triangulo(5, 4);
            Console.WriteLine($"Nombre de t1: {t1.Nombre}");
            Console.WriteLine($"Area de t1: {t1.CalcularArea()}");
            Console.WriteLine($"Perimetro de t1: {t1.CalcularPerimetro()}");
            Console.WriteLine("----------------------------------------------");

            //siempre recuerden que una clase abstracta no se puede instanciar
            //a menos que la apunte a un objeto de una clase compatible
            Figura f1 = new Rectangulo(8, 8);
            Console.WriteLine($"Nombre de f1: {f1.Nombre}");
            Console.WriteLine($"Area de f1: {f1.CalcularArea()}");
            Console.WriteLine($"Perimetro de f1: {f1.CalcularPerimetro()}");
            Console.WriteLine("----------------------------------------------");


        }
    }
}
