namespace _00_Proyecto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comentario de un renglon
            /*
             Comentario
            de varios
            renglones
             */

            Console.WriteLine("Imprime y pasa a la siguiente linea");
            Console.WriteLine("Hola UNAH");
            Console.Write("Imprimir pero no pasar a la siguiente linea");
            Console.Write("Sistemas");
            //es posible solo hacer un salto de linea:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hola");
            //puede usar caracteres de escape como en c++
            Console.WriteLine("Perro\nGato\nLoro\nBallena");
            Console.WriteLine("Rojo\tVerde\tAzul\tAmarillo");

            //colorear el texto
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Linea de texto color amarillo");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Linea de texto color verde");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Linea de texto color rojo");
            //regresar al color de fabrica
            Console.ResetColor();
            Console.WriteLine("Todo normal");

            //cambiar el color de fondo
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Fondo amarillo letra morada");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Fondo verde letra azul");

            Console.ResetColor();
        }
    }
}
