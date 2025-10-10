namespace _05_AsociacionClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hacer las pruebas
            Barrio bar1 = new Barrio("Guamilito", "Honduras", "Cortés", "San Pedro Sula");
            Barrio bar2 = new Barrio("El Carmen", "Honduras", "Cortés", "San Pedro Sula");

            Direccion dir1 = new Direccion(bar1, "7", "7", "Edificio COFISA");
            Direccion dir2 = new Direccion(bar2, "Principal", "N/A", "1033");
            Direccion dir3 = new Direccion(bar1, "8", "6", "N/A");

            Empresa e1 = new Empresa("Mecanica Rapida S.A.", "Automotriz", dir1, "");
            Empresa e2 = new Empresa("Baleadas Express","Comida",dir3,"25555454");

            Cargo car1 = new Cargo("Mecanico",Enums.JornadaLaboral.Matutina,e1,18000);
            Cargo car2 = new Cargo("Cocinero", Enums.JornadaLaboral.Vespertina, e2, 25000);
            Cargo car3 = new Cargo("Jefe de IT", Enums.JornadaLaboral.Mixta, e1, 45000);

            Estudiante estudiante1 = new Estudiante("20222019003","Filomeno","Sistemas",30,dir2,car1);
            estudiante1.Imprimir();

            Estudiante estudiante2 = new Estudiante("123", "Seferino", "Derecho", 70, dir3, null);
            estudiante2.Imprimir();
        }
    }
}
