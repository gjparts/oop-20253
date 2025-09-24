using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    public class Empleado
    {
        //Campos privados: se usan para almacenar los valores verdaderos
        //de las propiedades que se consideran privadas.
        //en C# se recomienda nombrarlas con un guion bajo al inicio
        //de su nombre y luego usar camel Case.
        //a esto se le conoce como Undescore prefix.
        private int _edad;
        private char _genero;
        private float _salario;
        private char _contrato;

        //Propiedades
        //las propiedades 100% publicas solo llevan get; set;
        public String Nombre { get; set; }
        //las propiedades privadas necesitan de validadores publicos
        public int Edad
        {
            get { return _edad; } //retornar el valor del campo privado
            set
            {
                //evaluar el valor que se pretende almacenar en el campo privado
                if (value >= 18)
                    this._edad = value; //se acepta
                else
                    //si no cumple la regla puede generar una excepcion
                    throw new ArgumentException("La edad debe ser >= 18");
            }
        }
        public char Genero
        {
            get { return this._genero; }
            set
            {
                if (value == 'M' || value == 'F' || value == 'X')
                    this._genero = value; //se acepta
                else
                    throw new ArgumentException("El genero solo admite M,F,X");
            }
        }
        public float Salario
        {
            get { return this._salario; }
            set
            {
                if (value >= 0)
                    this._salario = value; //se acepta
                else
                    throw new ArgumentException("El salario debe ser un numero >= 0");
            }
        }
        public char Contrato
        {
            get { return this._contrato; }
            set
            {
                if (value == 'T' || value == 'P')
                    this._contrato = value; //se acepta
                else
                    throw new ArgumentException("El contrato solo admite T, P");
            }
        }
        //Constructores
        public Empleado(String nombre, int edad, char genero, float salario, char contrato)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.Salario = salario;
            this.Contrato = contrato;
        }
        public Empleado(String nombre, int edad, char genero)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.Salario = 0.00f;
            this.Contrato = 'P';
        }
        //Metodos
        public void Imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********** Perfil del Empleado **********");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"Genero: {this.Genero}");
            Console.WriteLine($"Salario: {this.Salario}");
            Console.WriteLine($"Contrato: {this.Contrato}");
            Console.ResetColor();
        }
    }
}
