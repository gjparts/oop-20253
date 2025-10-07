using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_AsociacionClases
{
    public class Bateria
    {
        /*Observe que en el diagrama la asociacion entre Bateria
         y Fabricante es por Composicion (rombo negro), por lo tanto
        en algun momento debemos asegurarnos de que Marca no pueda
        quedar con valor null o sea sin memoria.*/
        //Campos privados
        private Fabricante _marca;

        //Propiedades
        public Fabricante Marca
        {
            get => this._marca;
            set
            {
                //impedir que Marca acepte valores null (Asociacion x Composicion)
                if (value == null)
                    throw new ArgumentException("Marca en Bateria no puede ser null");
                else
                    this._marca = value; //se acepta
            }
        }
        public float Miliamperios { get; set; }
        //Constructor
        public Bateria(Fabricante marca, float miliamperios)
        {
            this.Marca = marca;
            this.Miliamperios = miliamperios;
        }
    }
}
