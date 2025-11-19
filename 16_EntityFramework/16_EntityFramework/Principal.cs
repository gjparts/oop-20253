namespace _16_EntityFramework
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        //Metodo para cargar datos desde la base de datos
        public void CargarDatos()
        {
            try
            {
                //Crear un objeto que nos de acceso al contexto de la base de datos
                Data.GerardoContext contexto = new Data.GerardoContext();

                //Mostrar los datos y todas las columnas
                Grid1.DataSource = contexto.Productos.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //al dibujar el form:
            CargarDatos();

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
        }
    }
}
