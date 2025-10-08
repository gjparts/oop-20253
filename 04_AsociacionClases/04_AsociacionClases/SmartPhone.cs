using _04_AsociacionClases.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AsociacionClases
{
    public class SmartPhone
    {
        //Campos privados
        private Fabricante _marca;
        private String _modelo;
        private Bateria _bateria;

        //Propiedades
        public Fabricante Marca
        {
            get => this._marca;
            set
            {
                //impedir que Marca sea null (Asociación por composicion)
                if( value == null)
                    throw new ArgumentException("Marca en SmartPhone no puede ser null");
                else
                    this._marca = value; //se acepta
            }
        }
        public String Modelo
        {
            get => this._modelo;
            set
            {
                if (value.Trim().Length == 0)
                    throw new ArgumentException("Modelo en SmartPhone no puede ir en blanco");
                else
                    this._modelo = value; //se acepta
            }
        }
        public Capacidad Almacenamiento { get; set; }
        public Capacidad Ram { get; set; }
        public Bateria Bateria
        {
            get => this._bateria;
            set
            {
                //Impedir que Bateria sea null (asociacion por composicion)
                if (value == null)
                    throw new ArgumentException("Bateria en SmartPhone no puede ser null.");
                else
                    this._bateria = value; //se acepta
            }
        }
        //Chip1 y Chip2 tienen una relación por agregación, o sea que no son obligatorios
        //de llenar (se permite que sean null)
        public Chip Chip1 { get; set; }
        public Chip Chip2 { get; set; }
        
        //Constructor
        public SmartPhone(Fabricante marca, String modelo, Capacidad almacenamiento, Capacidad ram,
            Bateria bateria, Chip chip1, Chip chip2)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Almacenamiento = almacenamiento;
            this.Ram = ram;
            this.Bateria = bateria;
            this.Chip1 = chip1;
            this.Chip2 = chip2;
        }

        //Metodos
        public void Imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********** Ficha del SmartPhone **********");
            Console.WriteLine($"Fabricante: {this.Marca.Nombre}");
            Console.WriteLine($"Modelo: {this.Modelo}");

            //(int) imprime el valor numerico en lugar de la etiqueta para la enumeracion
            Console.WriteLine($"Almacenamiento: {(int)this.Almacenamiento} GB");
            Console.WriteLine($"RAM: {(int)this.Ram} GB");

            //Bateria no admite null por lo tanto es imposible que vean nula (no hay necesidad de validar)
            Console.WriteLine("Datos de la bateria:");
            Console.WriteLine($"\tMarca: {this.Bateria.Marca.Nombre}");
            Console.WriteLine($"\tMiliamperios: {this.Bateria.Miliamperios}");

            //Ahora toca imprimir chip1 y chip2, estos como su relacion es por agregacion
            //puede que vengan nulos (null) por lo tanto aqui si toca validar que en caso
            //de que vengan null entonces no los vamos a imprimir (ignorar)
            //en C# no se pude imprimir algo que sea null
            if( this.Chip1 != null)
            {
                //si Chip1 es distinto de null pues lo imprimimos
                Console.WriteLine("Chip 1:");
                Console.WriteLine($"\tOperador: {this.Chip1.Proveedor.Nombre}");
                Console.WriteLine($"\tNumero telefónico: {this.Chip1.NumeroTelefonico}");
            }
            if (this.Chip2 != null)
            {
                //si Chip2 es distinto de null pues lo imprimimos
                Console.WriteLine("Chip 2:");
                Console.WriteLine($"\tOperador: {this.Chip2.Proveedor.Nombre}");
                Console.WriteLine($"\tNumero telefónico: {this.Chip2.NumeroTelefonico}");
            }
            Console.ResetColor();
        }
    }
}
