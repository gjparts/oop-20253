using System.Security.Cryptography;

namespace _08_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*List: permite crear una colección que puede cambiar su tamaño de forma
             dinamica, sus elementos se posicionan de forma aleatoria en la memoria.
             Permiten almacenar elementos ya sea homogeneos o heterogeneos.*/

            //Colección heterogénea: cada item puede tener un tipo diferente
            List<Object> lista1 = new List<Object>();
            //observe el termino <Object> cuando se encierra el tipo
            //de dato entre <> a eso se le conoce como Generics
            //lo que hace es determinar el tipo de dato soportado
            //por una colección.
            //Object como Generic indica que la coleccion puede almacenar
            //cualquier elemento compatible con Object, en el caso de C# son
            //casi todos los tipos de dato de este lenguaje.

            //agregar items
            lista1.Add("Gerardo");
            lista1.Add(100);
            lista1.Add(45.8f);
            lista1.Add('X');
            lista1.Add(3.1416);
            lista1.Add(DateTime.Now);
            lista1.Add("UNAH");
            //Importante: una coleccion heterogenea si no sabe lo que esta haciendo
            //puede llegar a confundirse.

            //Imprimir un List usando for
            for(int i = 0; i < lista1.Count; i++)
                Console.WriteLine(lista1[i]);
            //en un List los elementos se numeran de 0 a N-1

            //Imprimir List usando foreach
            Console.WriteLine("****************************");
            foreach (Object item in lista1)
                Console.WriteLine(item);
            //se pone Object porque en lista1 todos sus elementos son <Object>

            Console.WriteLine("****************************");
            //Imprimir List usando Join
            Console.WriteLine( String.Join("\n",lista1) );
            //String.Join se puede usar tambien con Arreglos
            //el primer parametro \n es el separador entre cada item
            //el segnudo parametro es la coleccion a leer
            //String.Join devuelve un String que concatena todos los elementos
            //de una coleccion dada y entre cada uno coloca el separador que definamos.

            //El tamaño de un List:
            Console.WriteLine($"Tamaño de lista1: {lista1.Count}");

            //Coleccion Homogenea: todos los items son del mismo tipo
            //List de elementos String
            List<String> lista2 = new List<String>();
            lista2.Add("Rojo");
            lista2.Add("Verde");
            lista2.Add("Azul");
            lista2.Add("Rosa");

            Console.WriteLine("***************************");
            Console.WriteLine(String.Join("\n", lista2));

            //Coleccion homogenea de numeros enteros
            List<int> lista3 = new List<int>();
            lista3.Add(100);
            lista3.Add(7777);
            lista3.Add(-456);
            lista3.Add(2);
            lista3.Add(123);

            Console.WriteLine("***************************");
            Console.WriteLine(String.Join("\n", lista3));

            //List de solo elementos double
            List<double> lista4 = new List<double>();
            lista4.Add(3.1416);
            lista4.Add(2.25);
            lista4.Add(1.45663);

            Console.WriteLine("***************************");
            Console.WriteLine(String.Join("\n", lista4));

            //Para leer un item que esta en determinada posicion
            //de un List pues se hace como si fuese un arreglo:
            Console.WriteLine($"item 4 en lista3: {lista3[4]}");
            Console.WriteLine($"item 0 en lista4: {lista4[0]}");
            Console.WriteLine($"item 2 en lista1: {lista1[2]}");

            //Para eliminar un item en un List:
            lista2.RemoveAt(1);

            Console.WriteLine("***************************");
            Console.WriteLine(String.Join("\n", lista2));

            //Add se usa para agregar items en la ultima posicion del List
            //Insert se usa para agregar items en determinada posicion del List
            lista2.Insert(1, "Verde Fosforescente");

            Console.WriteLine("***************************");
            Console.WriteLine(String.Join("\n", lista2));

            //Para sobreescribir un elemento en determinada posicion
            //se hace como en los arreglos:
            lista2[3] = "Blanco hueso";

            Console.WriteLine("***************************");
            Console.WriteLine(String.Join("\n", lista2));
        }
    }
}
