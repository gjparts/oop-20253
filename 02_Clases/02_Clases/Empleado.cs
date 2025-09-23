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
    }
}
