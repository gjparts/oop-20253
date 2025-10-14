using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_AsociacionClases
{
    public class Factura
    {
        //Campos privados
        private Producto _producto1;

        //Propiedades
        public int Numero {  get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; } //Asoc. por Agregacion
        public Producto Producto1
        {
            get => this._producto1;
            set
            {
                if (value == null) //Asoc. por Composicion
                    throw new ArgumentException("Producto1 en Factura no puede ser null");
                else
                    this._producto1 = value; //se acepta
            }
        }
        public Producto Producto2 { get; set; }
        public Producto Producto3 { get; set; }
        public Producto Producto4 { get; set; }

        //Constructor
        public Factura(int numero, DateTime fecha, Cliente cliente, Producto producto1)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.Cliente = cliente;
            this.Producto1 = producto1;
        }

        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("*** Factura ***");
            Console.WriteLine($"Numero: {this.Numero}");
            //Fecha en formato yyyy/MM/dd
            Console.WriteLine($"Fecha: {this.Fecha.ToString("yyyy/MM/dd")}");

            //Cliente viene asociado por agregacion, por lo tanto
            //puede llegar a ser null.
            if( this.Cliente == null )
                Console.WriteLine("Cliente: Consumidor final");
            else
            {
                Console.WriteLine($"Cliente: {this.Cliente.Nombre}");
                Console.WriteLine($"RTN: {this.Cliente.Rtn}");
            }

            //tablita de productos, Producto1 nunca a venir null
            //en cambio Producto2 al 4 si pueden venir null
            //por lo tanto no se imprimen en caso de que vengan null
            float suma = 0.00f; //variable acumuladora
            Console.WriteLine("producto\tprecio");
            //Producto1 (siempre viene)
            Console.WriteLine($"{this.Producto1.Nombre}\t{this.Producto1.PrecioVenta}");
            suma += this.Producto1.PrecioVenta;
            //Producto2 al 4 no siempre vienen
            if( this.Producto2 != null)
            {
                Console.WriteLine($"{this.Producto2.Nombre}\t{this.Producto2.PrecioVenta}");
                suma += this.Producto2.PrecioVenta;
            }
            if (this.Producto3 != null)
            {
                Console.WriteLine($"{this.Producto3.Nombre}\t{this.Producto3.PrecioVenta}");
                suma += this.Producto3.PrecioVenta;
            }
            if (this.Producto4 != null)
            {
                Console.WriteLine($"{this.Producto4.Nombre}\t{this.Producto4.PrecioVenta}");
                suma += this.Producto4.PrecioVenta;
            }
            //Resultado redondeado a dos decimales (Math.Round)
            Console.WriteLine($"Subtotal: {Math.Round(suma,2)}");
            Console.WriteLine($"ISV 15%: {Math.Round(suma*0.15, 2)}");
            Console.WriteLine($"Total: {Math.Round(suma * 1.15, 2)}");
        }
    }
}
