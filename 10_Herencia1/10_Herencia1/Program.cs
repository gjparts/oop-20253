namespace _10_Herencia1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Gerardo", 43, Enums.Genero.Masculino, "20012002049", "Ing. Industrial");
            //la clase Estudiante hereda de la clase Persona por lo tanto tiene 3 atributos de Persona
            //y 2 atributos de Estudiante, así como 2 metodos (1 de Persona y 1 de Estudiante)
            Console.WriteLine("Datos de e1 ************");
            Console.WriteLine($"Nombre: {e1.Nombre}");
            Console.WriteLine($"Edad: {e1.Edad}");
            Console.WriteLine($"Genero: {e1.Genero}");
            Console.WriteLine($"Cuenta: {e1.Cuenta}");
            Console.WriteLine($"Carrera: {e1.Carrera}");
            e1.Saludar();
            e1.Estudiar();

            Empleado em1 = new Empleado();
            Console.WriteLine("Datos de em1 ************");
            Console.WriteLine($"Nombre: {em1.Nombre}");
            Console.WriteLine($"Edad: {em1.Edad}");
            Console.WriteLine($"Genero: {em1.Genero}");
            Console.WriteLine($"Salario: {em1.Salario}");
            Console.WriteLine($"Cargo: {em1.Cargo}");
            em1.Saludar();
            em1.Trabajar();

            Empleado em2 = new Empleado("Kurko Bain", 27, Enums.Genero.Masculino, 1000000, "Vocalista");
            Console.WriteLine("Datos de em2 ************");
            Console.WriteLine($"Nombre: {em2.Nombre}");
            Console.WriteLine($"Edad: {em2.Edad}");
            Console.WriteLine($"Genero: {em2.Genero}");
            Console.WriteLine($"Salario: {em2.Salario}");
            Console.WriteLine($"Cargo: {em2.Cargo}");
            em2.Saludar();
            em2.Trabajar();
        }
    }
}
