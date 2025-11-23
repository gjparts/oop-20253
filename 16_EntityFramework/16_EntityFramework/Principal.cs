using _16_EntityFramework.Models;

namespace _16_EntityFramework
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        //Metodo para cargar datos desde la base de datos
        public bool CargarDatos()
        {
            try
            {
                //Crear un objeto que nos de acceso al contexto de la base de datos
                Data.GerardoContext contexto = new Data.GerardoContext();

                //Mostrar los datos y todas las columnas
                Grid1.DataSource = contexto.Productos.ToList();

                //si llego hasta aqui la carga de datos fue exitosa
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //si llego aqui es porque la carga de datos ha fallado
                return false;
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //al dibujar el form:
            if (CargarDatos() == false) return; //si cargar datos falla entonces termina el evento Load

            //Personalizar Grid1
            //modo de seleccion: fila completa
            Grid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //ocultar el selector de filas de la izquierda
            Grid1.RowHeadersVisible = false;
            //evitar poder cambiar la altura de fila
            Grid1.AllowUserToResizeRows = false;
            //evitar que se pueda escribir dentro del Grid
            Grid1.ReadOnly = true;
            //evitar eliminar y agregar filas en el Grid
            Grid1.AllowUserToAddRows = false;
            Grid1.AllowUserToDeleteRows = false;
            //opcional: deshabilitar el poder cambiar ancho de columna
            Grid1.AllowUserToResizeColumns = false;
            //prohibir poder mover las columnas de su posicion
            Grid1.AllowUserToOrderColumns = false;

            //colocar etiquetas a los titulos de algunas columnas
            Grid1.Columns["ProductoID"].HeaderText = "Identificador único";
            Grid1.Columns["Nombre"].HeaderText = "Nombre del Producto";
            Grid1.Columns["PrecioVenta"].HeaderText = "Precio de Venta";

            //alineacion del texto de algunas columnas
            Grid1.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Grid1.Columns["PrecioVenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            Grid1.Columns["Existencias"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //dar formato de miles a las columnas de numeros (mascara de entrada)
            Grid1.Columns["Costo"].DefaultCellStyle.Format = "#,###,##0.00";
            Grid1.Columns["PrecioVenta"].DefaultCellStyle.Format = "#,###,##0.00";
            Grid1.Columns["Existencias"].DefaultCellStyle.Format = "#,###,##0.00";
            Grid1.Columns["ProductoID"].DefaultCellStyle.Format = "00000000";

            //mandar a ejecutar el metodo del evento SizeChanged:
            //para autoajustar los anchos de columnas
            this.Principal_SizeChanged(null, null);
        }

        private void Principal_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                //en caso de no haber coliumnas termina el evento
                if (Grid1.Columns.Count == 0) return;

                //establecer los anchos de las columnas del grid
                //columnas de ancho fijo:
                Grid1.Columns["ProductoID"].Width = 80; //pixels
                Grid1.Columns["Codigo"].Width = 70;
                Grid1.Columns["Costo"].Width = 65;
                Grid1.Columns["PrecioVenta"].Width = 65;
                Grid1.Columns["Existencias"].Width = 65;

                //columnas de ancho ajustable de acuerdo al ancho del grid:
                Grid1.Columns["Nombre"].Width = Grid1.Width * 30 / 100; //30% del ancho del grid
                Grid1.Columns["Comentarios"].Width = Grid1.Width * 45 / 100; //45% del ancho del grid
            }
            catch (Exception)
            {
                //no mostrar mensajes en caso de falla
            }
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            //crear un objeto de clase Detalle y dibujarlo en la pantalla
            Detalle d = new Detalle();
            //dibujar el Form del objeto de forma Modal
            d.ShowDialog();

            //se ha cerrado la ventana de detalle, verificamos
            //si se hizo click en Aceptar:
            if (d.DialogResult == DialogResult.OK)
            {
                try
                {
                    //Importante: debe importar a Models arriba de la clase
                    //Crear un nuevo objeto de clase Producto
                    Producto registro = new Producto();
                    //No olvide hacer Public la propiedad Modifiers de las cajas de texto
                    //en el form de Detalle
                    registro.Codigo = d.Codigo.Text.Trim();
                    registro.Nombre = d.Nombre.Text.Trim();
                    registro.Costo = decimal.Parse(d.Costo.Text);
                    registro.PrecioVenta = decimal.Parse(d.PrecioVenta.Text);
                    registro.Existencias = int.Parse(d.Existencias.Text);
                    registro.Comentarios = d.Comentarios.Text.Trim();

                    //Crear objeto para tener acceso al contexto de la base de datos
                    Data.GerardoContext contexto = new Data.GerardoContext();

                    //Agregar el producto al contexto
                    contexto.Productos.Add(registro);
                    //Escribir los cambios en la base de datos
                    contexto.SaveChanges();
                    //cargar de nuevo los datos en el grid
                    this.CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //destruir el form Detalle de la memoria
            d.Dispose();
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            //si no hay filas en el Grid no continua
            if (Grid1.RowCount == 0) return;

            try
            {
                //Crear objeto para tener acceso al contexto de la base de datos
                Data.GerardoContext contexto = new Data.GerardoContext();

                //Buscar el objeto del Producto cuyo ProductoID sea el seleccionado en el Grid:
                Producto registro = contexto.Productos.Find(Grid1.CurrentRow.Cells["ProductoID"].Value);
                if (registro == null) return; //en caso de no encontrar el producto termina

                //crear un form Detalle
                Detalle d = new Detalle();
                //antes de mostrar el form, llenar las cajas de texto
                //con los datos del producto recuperado desde la base de datos
                d.Codigo.Text = registro.Codigo;
                d.Nombre.Text = registro.Nombre;
                d.Costo.Text = registro.Costo.ToString();
                d.PrecioVenta.Text = registro.PrecioVenta.ToString();
                d.Existencias.Text = registro.Existencias.ToString();
                d.Comentarios.Text = registro.Comentarios;

                d.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
