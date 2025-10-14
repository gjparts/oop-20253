namespace _06_AsociacionClases
{
    internal class Program
    {
        static void Main(string[] args)
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

            Factura f1 = new Factura(1, DateTime.Now, c1, p2);
            f1.Imprimir();

            DateTime fecha1 = new DateTime(2025, 9, 15);
            Factura f2 = new Factura(2, fecha1, null, p1);
            f2.Producto2 = p5;
            f2.Producto3 = p4;
            f2.Producto4 = p4;
            f2.Imprimir();

            Factura f3 = new Factura(3, new DateTime(2025, 8, 2), c2, p3);
            f3.Producto4 = p2;
            f3.Imprimir();
        }
    }
}
