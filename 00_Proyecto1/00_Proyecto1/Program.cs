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

            //se puede usar diferentes colores en una sola linea
            //por medio de Write
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Kiwi");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Naranja");
            Console.BackgroundColor  = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Objetos");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Sandia");
            Console.ResetColor();
            Console.WriteLine();

            //para poder imprimir multiples lineas en un solo String
            //en C# debe poner el caracter @ antes del String, esto tambien
            //les permite ignorar los caracteres de escape.
            Console.WriteLine(@"
        _   ,_,   _
       / `'=) (='` \
      /.-.-.\ /.-.-.\ 
      `      ""      `
");

            //hacer una pausa
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true);

            //limpiar la pantalla
            Console.Clear();

            //establecer en que posicion de la pantalla va a imprimir.
            Console.SetCursorPosition(70, 3);
            Console.WriteLine("Texto en columna 70, linea 3");

            Console.SetCursorPosition(10, 0);
            Console.WriteLine("Texto en columna 10, linea 0");

            //importante: la ultima linea en que la se imprime es donde quedara el cursor
            //para futuras impresiones.

            Console.SetCursorPosition(30, 7);
            Console.WriteLine("Texto random");

            //hacer una pausa
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true);

            //limpiar la pantalla
            Console.Clear();

            //variables
            int x = 5;
            double dd = 3.1416;
            float ff = 2.25f;
            long num = 1234567891234561L;

            //caza de errores
            try
            {
                //captura de datos en variables
                int a;
                Console.Write("Digite un entero: ");
                a = int.Parse(Console.ReadLine());

                double d1;
                Console.Write("Digite un double: ");
                d1 = double.Parse(Console.ReadLine());

                float f1;
                Console.Write("Digite un float: ");
                f1 = float.Parse(Console.ReadLine());

                long l1;
                Console.Write("Digite un long: ");
                l1 = long.Parse(Console.ReadLine());

                //imprimir variables
                //concatenar de forma tradicional:
                Console.WriteLine("El valor de a es "+a);
                //concatenar usando sintaxis de interpolacion (signo de dolar antes del String)
                Console.WriteLine($"El valor de a es {a} y el valor de d1 es {d1}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Debe ingresar solo numeros");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
