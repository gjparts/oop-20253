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

            Empleado e1 = new Empleado();
            e1.Edad = 18;
            Console.WriteLine(e1.Edad);
        }
    }
}
