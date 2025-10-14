using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_AsociacionClases
{
    public class Producto
    {
        //Campos privados
        private CategoriaProducto _categoriaProducto;

        //Propiedades
        public String Nombre { get; set; }
        public CategoriaProducto Categoria
        {
            get => this._categoriaProducto;
            set
            {
                if (value == null) //Asoc. por composicion
                    throw new ArgumentException("Categoria en Producto no puede ser null");
                else
                    this._categoriaProducto = value; //se acepta
            }
        }
        public float PrecioVenta { get; set; }

        //Constructor
        public Producto(String nombre, CategoriaProducto categoria, float precioVenta)
        {
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.PrecioVenta = precioVenta;
        }
    }
}
