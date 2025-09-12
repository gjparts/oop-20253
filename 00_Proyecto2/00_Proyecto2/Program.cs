namespace _00_Proyecto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Sumar(2, 3));
            Console.WriteLine(Sumar(5, 4));
            Saludar();
            Console.WriteLine(Adicionar(5, 4));
            Despedirse();
        }
        //metodos
        static double Sumar(double a, double b)
        {
            return a + b;
        }
        static void Saludar()
        {
            Console.WriteLine("Hola");
        }
        //Funciones de flecha: se recomienda usarlas unicamente cunado
        //solo habra una instruccion dentro de la funcion/metodo.
        static double Adicionar(double a, double b) => a + b;
        static void Despedirse() => Console.WriteLine("Adios");
    }
}
