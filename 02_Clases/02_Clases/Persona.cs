using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    public class Persona
    {
        //Propiedades
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public char Genero { get; set; }
        public String DNI { get; set; }
        /*Constructor:
        Es un metodo que devuelve memoria para una instancia de una clase
        -> Un constructor se puede usar para inicializar las propiedades
        -> Se recomienda que sean publicos
        -> Pueden tener o no parametros
        -> en C# siempre se llaman igual que la clase
        -> No tienen tipo de dato puesto que devuelven una instancia de la clase (objeto)
        -> en C# una clase puede tener varios constructores siempre y cuando
           estos tenga diferente firma
        -> En C# si no define ningun constructor entonces se asume que la clase tiene
           un constructor sin parametros
        -> Los constructores no siempre se usan para inicializar Propiedades, tambien
           se pueden usar para disparar eventos, conexiones o acciones.*/

        public Persona()
        {
            //Constructor sin parametros
            this.Nombre = "no tiene";
            this.Edad = 0;
            this.Genero = 'X';
            this.DNI = "no definido";
        }
        public Persona(String nombre, int edad)
        {
            //constructor con dos parametros
            //en C# se recomienda usar camel Case para nombrar los parametros de metodo
            //en camel Case la primer letra es minuscula y las siguiente palabra
            //va en mayuscula: ciudadOrigen  nombreDelConyuge  salarioMensualEmpleado
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = 'X';
            this.DNI = "no definido";
        }
        public Persona(String nombre, int edad, char genero, String dni)
        {
            //constructor con todos los parametros
            this.Nombre= nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.DNI = dni;
        }

        //Metodos (llevan tipo de dato)
        public void Imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("********** Perfil de Persona **********");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"Genero: {this.GetGeneroDescripcion()}");
            Console.WriteLine($"DNI: {this.DNI}");
            Console.WriteLine($"Es mayor de edad: {this.EsMayorDeEdad()}");
            Console.ResetColor();
        }
        public bool EsMayorDeEdad()
        {
            if (this.Edad >= 18)
                return true;
            else
                return false;
        }
        public String GetGeneroDescripcion()
        {
            if (this.Genero == 'M') return "Masculino";
            if (this.Genero == 'F') return "Femenino";
            if (this.Genero == 'X') return "Otros";
            return "No configurado en el programa.";
        }
    }
}
