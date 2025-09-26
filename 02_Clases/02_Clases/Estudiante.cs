using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    public class Estudiante
    {
        //Campos privados
        private String _nombre;
        private String _cuenta;
        private String _dni;
        private char _genero;
        private int _edad;
        private float _promedio;
        private String _carrera;

        //Propiedades
        public String Nombre
        {
            get { return this._nombre; }
            set
            {
                if (value.Trim().Length >= 5)
                    this._nombre = value; //se acepta
                else
                    throw new ArgumentException("Nombre debe ser de al menos 5 caracteres.");
            }
        }
        public String Cuenta
        {
            get => this._cuenta; //en get puede usar funcion de flecha porque solo es una intruccion
            set
            {
                if (value.Trim().Length == 11)
                    this._cuenta = value; //se acepta
                else
                    throw new ArgumentException("Cuenta debe ser de 11 caracteres.");
            }
        }
        public String DNI
        {
            get => this._dni;
            set
            {
                if (value.Trim().Length == 13)
                    this._dni = value; // se acepta
                else
                    throw new ArgumentException("DNI debe ser de 13 caracteres");
            }
        }
        public char Genero
        {
            get => this._genero;
            set
            {
                if (value == 'M' || value == 'F' || value == 'X')
                    this._genero = value; //se acepta
                else
                    throw new ArgumentException("Genero solo admite M, F, X");
            }
        }
        public int Edad
        {
            get => this._edad;
            set
            {
                if (value >= 12)
                    this._edad = value; //se acepta
                else
                    throw new ArgumentException("Edad debe ser >= 12");
            }
        }
        public float Promedio
        {
            get => this._promedio;
            set
            {
                if (value >= 0 && value <= 100)
                    this._promedio = value; //se acepta
                else
                    throw new ArgumentException("Promedio debe estar entreo 0 y 100");
            }
        }
        public String Carrera
        {
            get => this._carrera;
            set
            {
                if (value.Trim().Length >= 10)
                    this._carrera = value; //se acepta
                else
                    throw new ArgumentException("Carrera debe ser de al menos 10 caracteres.");
            }
        }
        //Constructores
        public Estudiante(String nombre, String cuenta, String dni, int edad, char genero,
            float promedio, String carrera)
        {
            this.Nombre = nombre;
            this.Cuenta = cuenta;
            this.DNI = dni;
            this.Edad = edad;
            this.Genero = genero;
            this.Promedio = promedio;
            this.Carrera = carrera;
        }
        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("*************** Perfil de Estudiante ***************");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Cuenta: {this.Cuenta}");
            Console.WriteLine($"DNI: {this.DNI}");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"Genero: {this.Genero}");
            Console.WriteLine($"Promedio: {this.Promedio}");
            Console.WriteLine($"Carrera: {this.Carrera}");
        }
    }
}
