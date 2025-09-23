using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Clases
{
    public class Carro
    {
        //Propiedades
        /// <summary>Marca del vehiculo</summary>
        public String Marca { get; set; }
        /// <summary>Modelo del vehiculo, por ejemplo: Civic, Corolla, CRV</summary>
        public String Modelo { get; set; }
        /// <summary>Color del vehiculo</summary>
        public String Color { get; set; }
        /// <summary>Año del vehiculo</summary>
        public int Anio { get; set; }
        
        //Constructores
        public Carro()
        {
            this.Marca = "no definida";
            this.Modelo = "no definido";
            this.Color = "no definido";
            this.Anio = 0;
        }
        public Carro(String marca, String modelo, String color, int anio)
        {
            this.Marca= marca;
            this.Modelo= modelo;
            this.Color = color;
            this.Anio = anio;
        }
        //Metodos
        /// <summary>Metodo que imprime una ficha del carro</summary>
        public void Imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("************ CARRO ************");
            Console.WriteLine($"Marca: {this.Marca}");
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"Color: {this.Color}");
            Console.WriteLine($"Anio: {this.Anio}");
            Console.ResetColor();
        }
        /// <summary>
        /// Metodo que suma dos numeros
        /// </summary>
        /// <param name="a">El valor del primer numero</param>
        /// <param name="b">El valor del segundo numero</param>
        /// <returns>Retorna un numero entero que es la suma de los dos numeros</returns>
        public int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
