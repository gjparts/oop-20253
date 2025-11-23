using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_EntityFramework
{
    public partial class Detalle : Form
    {
        public Detalle()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            //Cerrar el Form indicando que se ha presionado Cancelar
            this.DialogResult = DialogResult.Cancel;
            this.Close(); //cerrar Form sin destruirlo de la memoria
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validaciones
                if( Codigo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Código no puede ir en blanco");
                    return; //termina el evento
                }
                if (Nombre.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Nombre no puede ir en blanco");
                    return; //termina el evento
                }
                if( Double.Parse(Costo.Text) < 0)
                {
                    MessageBox.Show("Costo no puede ser negativo");
                    return;
                }
                if (Double.Parse(PrecioVenta.Text) <= 0)
                {
                    MessageBox.Show("Costo no puede ser negativo o CERO");
                    return;
                }
                if (Double.Parse(Existencias.Text) == 0)
                {
                    MessageBox.Show("Existencias no pueden ir en blanco");
                    return;
                }
                //se han superado todas las validaciones:
                //cerrar el Form indicando que se ha presionado Aceptar
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Revise que los datos digitados sean correcto.");
            }
        }
    }
}
