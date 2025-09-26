namespace _02_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //en C# cuando una clase no tiene constructor definido
            //el lenguaje le asigna un constructor sin parametros
            //que unicamente devuelve el objeto en determinada direccion
            //de memoria
            Mascota ma1 = new Mascota();
            Console.WriteLine("Valores de las propiedades de ma1:");
            Console.WriteLine("Nombre: "+ma1.Nombre);
            Console.WriteLine($"Especie: {ma1.Especie}");
            Console.WriteLine($"Edad: {ma1.Edad}");
            Console.WriteLine($"Genero: {ma1.Genero}");
            Console.WriteLine($"Direccion hash de ma1: {ma1.GetHashCode()}");

            Mascota ma2 = new Mascota();
            //colocar manualmente los valores de las propiedades:
            ma2.Nombre = "Chispita";
            ma2.Especie = "Gato";
            ma2.Edad = 2;
            ma2.Genero = 'H';
            Console.WriteLine("*************************************");
            Console.WriteLine("Nombre: " + ma2.Nombre);
            Console.WriteLine($"Especie: {ma2.Especie}");
            Console.WriteLine($"Edad: {ma2.Edad}");
            Console.WriteLine($"Genero: {ma2.Genero}");
            Console.WriteLine($"Direccion hash de ma2: {ma2.GetHashCode()}");

            Console.WriteLine("***********************************");
            Persona per1 = new Persona();
            per1.Imprimir();

            Persona per2 = new Persona("Gerardo",42);
            per2.Imprimir();

            Persona per3 = new Persona("Filomeno Colinas", 77, 'M', "1111111111111");
            per3.Imprimir();

            Carro c1 = new Carro();
            c1.Imprimir();

            Carro c2 = new Carro("Honda", "CRV", "Azul", 2016);
            c2.Imprimir();

            Empleado em1 = new Empleado("Estevancito Maravilla", 80, 'M');
            em1.Imprimir();

            Empleado em2 = new Empleado("Dave Mustaine", 50, 'M', 50000, 'P');
            em2.Imprimir();

            //gracias al get del validador publico se puede tambien leer datos
            //de campos privados:
            Console.WriteLine("La edad de em2 es "+em2.Edad);
            //tambien puede utilizar el set del validador publico:
            em2.Edad = 55;
            Console.WriteLine($"La edad de em2 es {em2.Edad}");

            //No olviden tambien que las excepciones disparadas con throw en las
            //clases pueden ser interceptadas con try-catch
            try
            {
                em2.Edad = -50;
            }
            catch (Exception ex)
            {
                //asi se imprime el mensaje enviado por throw:
                Console.WriteLine(ex.Message);
            }

            Estudiante es1 = new Estudiante("Josue Portillo", "20012002049", "1234123412345", 42,
                                            'M', 84, "Ing. Sistemas");
            es1.Imprimir();

            Instructor ins1 = new Instructor();
            ins1.Nombre = "Rambo Perez";
            ins1.Edad = 30;
            ins1.Genero = Enums.Genero.Masculino;
            ins1.TipoContrato = Enums.TipoContrato.Permanente;
            ins1.TipoInstructor = Enums.TipoInstructor.General;

        }
    }
}
