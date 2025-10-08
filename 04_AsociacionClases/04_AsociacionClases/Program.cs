namespace _04_AsociacionClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear los objetos de las clases comenzando por los no dependientes y terminando por los dependientes
            Fabricante apple = new Fabricante("Apple Computer Inc.", "USA", "Tim Cook");
            Fabricante xioami = new Fabricante("Xioami", "China", "");
            Fabricante samsung = new Fabricante("Samsung", "Korea", "");

            Operador tigo = new Operador("TIGO", "Centroamerica");
            Operador claro = new Operador("Claro", "Honduras");

            Bateria bat1 = new Bateria(samsung, 4500);
            Bateria bat2 = new Bateria(xioami, 5500);
            Bateria bat3 = new Bateria(samsung, 6000);

            Bateria bat4 = new Bateria(new Fabricante("LG Chemical", "Korea", ""), 6600);
            //observe en bat4 que el fabricante fue creado dentro del constructor, a esto se le conoce
            //como objeto volátil, el cual solo se crea para usarse una vez en determinada circunstancia.
            //los objetos volatiles se usan mucho cuando no amerita la creacion de una variable para
            //algo que solo vamos a ocupar una sola vez.
            //podemos tener accesoa los datos de este objeto volatil:
            Console.WriteLine($"Marca de bat4: {bat4.Marca.Nombre}");

            Chip sim1 = new Chip(tigo, 99991515);
            Chip sim2 = new Chip(claro, 33331515);
            Chip sim3 = new Chip(tigo, 98989999);
            Chip sim4 = new Chip(new Operador("DIGICEL", "Guatemala"), 88887777);

            //creacion de los telefonos:
            SmartPhone cel1 = new SmartPhone(apple, "iPhone 16 PRO Max", Enums.Capacidad.c512GB, Enums.Capacidad.c16GB, bat4, sim1, null);
            cel1.Imprimir();

            SmartPhone cel2 = new SmartPhone(xioami, "RedMI Note 13", Enums.Capacidad.c256GB, Enums.Capacidad.c8GB, bat2, sim2, sim4);
            cel2.Imprimir();

            //tambien puede crear un objeto volatil de un solo uso para imprimirlo:
            new SmartPhone(samsung, "Galaxy S22", Enums.Capacidad.c256GB, Enums.Capacidad.c8GB, bat1, null, null).Imprimir();
        }
    }
}
