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
        private Producto[] _productos;
        //_productos es un Arreglo de elementos de clase Producto

        //Propiedades
        public int Numero {  get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; } //Asoc. por Agregacion
        public Producto[] Productos
        {
            get => this._productos;
            set
            {
                //el arreglo no puede ser null
                if (value == null)
                    throw new ArgumentException("Productos en Factura no puede ser null");
                else
                {
                    //el arreglo debe tener al menos un item
                    if (value.Length == 0)
                        throw new ArgumentException("Productos debe tener al menos un item");
                    else
                    {
                        //item 0 no puede venir null
                        if (value[0] == null)
                            throw new ArgumentException("Elemento 0 en Productos no puede ser null");
                        else
                            this._productos = value; //se acepta
                    }
                }
            }
        }

        //Constructor
        public Factura(int numero, DateTime fecha, Cliente cliente, Producto[] productos)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.Cliente = cliente;
            this.Productos = productos;
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
            
            //recorrer cada item del arreglo de productos
            foreach( Producto item in this.Productos)
            {
                //ignorar cualquier item que sea null
                if( item != null)
                {
                    Console.WriteLine($"{item.Nombre}\t{item.PrecioVenta}");
                    suma += item.PrecioVenta; //sumar precio del producto al subtotal
                }
            }

            //Resultado redondeado a dos decimales (Math.Round)
            Console.WriteLine($"Subtotal: {Math.Round(suma,2)}");
            Console.WriteLine($"ISV 15%: {Math.Round(suma*0.15, 2)}");
            Console.WriteLine($"Total: {Math.Round(suma * 1.15, 2)}");
        }
    }
}
