using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Multiplicidad
{
    public class Persona
    {
        //Propiedades
        public String Identidad {  get; set; }
        public String Nombre { get; set; }
        public String Telefono { get; set; }
        public Direccion Direccion { get; set; } //Asoc. por agregacion
        public Empresa EmpresaLabora { get; set; } //Asoc. por agregacion
        public Mascota[] Mascotas { get; set; } //Asoc. por agregacion, Multiplicidad
        public List<Diploma> Diplomas { get; set; } //Asoc. por agregacion, Multiplicidad
        public Persona Conyuge { get; set; } //Asoc. por agregacion, Referencia circular
        public List<Persona> Hijos { get; set; } //Asoc. por agregacion, Referencia circular, Multiplicidad

        //Constructor
        public Persona(String identidad, String nombre, String telefono)
        {
            this.Identidad = identidad;
            this.Nombre = nombre;
            this.Telefono = telefono;
        }

        //Metodos
        public void Imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------- Perfil de Persona ----------");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Identidad: {this.Identidad}");
            Console.WriteLine($"Telefono {this.Telefono}");
            //Direccion viene por agregacion asi que puede llegar a ser null
            if( this.Direccion != null)
            {
                Console.WriteLine("Direccion:");
                Console.WriteLine($"\tBarrio o Colonia: {this.Direccion.Colonia.Nombre}");
                Console.WriteLine($"\tCalle: {this.Direccion.Calle}");
                Console.WriteLine($"\tAvenida: {this.Direccion.Avenida}");
                Console.WriteLine($"\tCasa: {this.Direccion.Casa}");
            }
            //EmpresaLabora puede ser null porque esta por agregacion
            if( this.EmpresaLabora != null)
            {
                Console.WriteLine("Empresa donde trabaja:");
                Console.WriteLine($"\tNombre: {this.EmpresaLabora.Nombre}");
                Console.WriteLine($"\tTelefono: {this.EmpresaLabora.Telefono}");
                Console.WriteLine($"\tBarrio o colonia: {this.EmpresaLabora.Direccion.Colonia.Nombre}");
            }
            //Coleccion de Mascotas: puede llegar a venir null (agregacion)
            if( this.Mascotas != null)
            {
                //solo si el arreglo tiene elementos vamos a imprimir
                if( this.Mascotas.Length > 0)
                {
                    Console.WriteLine("Mascotas:");
                    foreach (Mascota item in this.Mascotas) //para cada Mascota en this.Mascotas
                    {
                        //si el item es diferente de null lo imprimimos
                        if( item != null )
                            Console.WriteLine($"\t* {item.Nombre} ({item.Especie})");
                    }
                }
            }
            //Coleccion de Diplomas: puede llegar a ser null (agregacion)
            if( this.Diplomas != null)
            {
                //imprimir seccion solo si hay elementos
                if( this.Diplomas.Count > 0)
                {
                    Console.WriteLine("Diplomas:");
                    foreach (Diploma item in this.Diplomas)
                    {
                        if( item != null)
                        {
                            Console.WriteLine($"\t* {item.Nombre} ({item.Institucion})");
                        }
                    }
                }
            }
            //Conyuge viene por agregacion, puede ser null
            if( this.Conyuge != null)
            {
                Console.WriteLine("Conyuge:");
                Console.WriteLine($"\tNombre: {this.Conyuge.Nombre}");
                Console.WriteLine($"\tTelefono: {this.Conyuge.Telefono}");
            }
            //Coleccion de hijos: por agregacion y puede ser null
            if( this.Hijos != null)
            {
                if( this.Hijos.Count > 0)
                {
                    Console.WriteLine("Hijos:");
                    foreach (Persona item in this.Hijos)
                    {
                        if( item != null) Console.WriteLine($"\t* {item.Nombre}");
                    }
                }
            }
        }
    }
}
