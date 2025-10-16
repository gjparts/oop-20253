namespace _06_AsociacionClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cliente c1 = new Cliente("Gerardo Portillo","123","1234-1234","");
                Cliente c2 = new Cliente("Mario Verde", "777777", "1111-1111", "");

                CategoriaProducto cat1 = new CategoriaProducto("Bebidas", "18");
                CategoriaProducto cat2 = new CategoriaProducto("Verduras y Frutas", "1");
                CategoriaProducto cat3 = new CategoriaProducto("Churros", "8");

                Producto p1 = new Producto("Coca Cola 3L",cat1,65);
                Producto p2 = new Producto("Tomate LB", cat2, 15);
                Producto p3 = new Producto("Papa LB", cat2, 14);
                Producto p4 = new Producto("Zambos Grande", cat3, 45);
                Producto p5 = new Producto("Rica Sula", cat3, 8);

                Producto[] prods1 = { p2 };
                Factura f1 = new Factura(1, DateTime.Now, c1, prods1);
                f1.Imprimir();

                Producto[] prods2 = { p1, p5, p4, p4 };
                DateTime fecha1 = new DateTime(2025, 9, 15);
                Factura f2 = new Factura(2, fecha1, null, prods2);
                f2.Imprimir();

                Producto[] prods3 = { p3, p2 };
                Factura f3 = new Factura(3, new DateTime(2025, 8, 2), c2, prods3);
                f3.Imprimir();

                Producto[] prods4 = { p2, p1, p1, p5, p4, p2, p2, p5, p1, p1 };
                Factura f4 = new Factura(4, DateTime.Now, c1, prods4);
                f4.Imprimir();

                //esto da error porque viola la regla de que el item 0 en Productos no debe ser null
                /*
                Producto[] prods5 = { null, p1, p2 };
                Factura f5 = new Factura(5, DateTime.Now, c2, prods5);
                f5.Imprimir();
                */

                //la coleccion de Productos no puede ser null
                /*
                Factura f6 = new Factura(6, DateTime.Now, c2, null);
                f6.Imprimir();
                */

                //la coleccion de Productos debe traer al menos un producto
                /*
                Producto[] prods7 = { };
                Factura f7 = new Factura(7, DateTime.Now, c2, prods7);
                */

                //es posible instanciar un arreglo directamente en el constructor
                //sin necesidad de una variable
                Factura f8 = new Factura(8, DateTime.Now, c2,new Producto[] { p5, p2, p1, p1, p3, p1, p1 } );
                f8.Imprimir();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
