using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AsociacionClases
{
    public class Estudiante
    {
        //Campos privados
        private int _edad;
        public Direccion _direccion;

        //Propiedades
        public String Cuenta { get; set; }
        public String Nombre { get; set; }
        public String Carrera { get; set; }
        public int Edad
        {
            get => this._edad;
            set
            {
                if (value >= 0)
                    this._edad = value; //se acepta
                else
                    throw new ArgumentException("Edad en Estudiante debs er >= 0");
            }
        }
        public Direccion Direccion
        {
            get => this._direccion;
            set
            {
                if( value == null )
                    throw new ArgumentException("Direccion en Estudiante no puede ser null");
                else
                    this._direccion = value; //se acepta
            }
        }
        //la asociacion con Cargo es por agregacion (no importa que venga null)
        public Cargo Trabajo { get; set; }

        //Constructor
        public Estudiante(String cuenta, String nombre, String carrera, int edad, Direccion direccion, Cargo trabajo)
        {
            this.Cuenta = cuenta;
            this.Nombre = nombre;
            this.Carrera = carrera;
            this.Edad = edad;
            this.Direccion = direccion;
            this.Trabajo = trabajo;
        }

        //Metodos
        public void Imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("********** Perfil del Estudiante **********");
            Console.WriteLine($"Cuenta: {this.Cuenta}");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Carrera: {this.Carrera}");
            Console.WriteLine($"Edad: {this.Edad}");

            //la Direccion y su Barrio jamas van a ser null gracias a los set
            //por lo tanto no lo validamos antes de imprimir
            Console.WriteLine("Dirección:");
            Console.WriteLine($"\tBarrio: {this.Direccion.Barrio.Nombre}");
            Console.WriteLine($"\tCalle: {this.Direccion.Calle}");
            Console.WriteLine($"\tAvenida: {this.Direccion.Avenida}");
            Console.WriteLine($"\tCasa: {this.Direccion.Casa}");
            Console.WriteLine($"\tCiudad: {this.Direccion.Barrio.Ciudad}");
            Console.WriteLine($"\tMunicipio: {this.Direccion.Barrio.Municipio}");
            Console.WriteLine($"\tPais: {this.Direccion.Barrio.Pais}");

            //Trabajo puede llegar a ser null ya que esta relacionado por agregacion
            //por lo tanto si es null no lo vamos a imprimir
            if( this.Trabajo != null)
            {
                Console.WriteLine("Informacion laboral:");
                Console.WriteLine($"\tEmpresa: {this.Trabajo.Empresa.Nombre}");
                Console.WriteLine($"\tCargo: {this.Trabajo.Descripcion}");
                Console.WriteLine($"\tCiudad: {this.Trabajo.Empresa.Direccion.Barrio.Ciudad}");
                Console.WriteLine($"\tPais: {this.Trabajo.Empresa.Direccion.Barrio.Pais}");
            }
        }
    }
}
