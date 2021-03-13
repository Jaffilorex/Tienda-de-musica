using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tienda_de_música
{
    public partial class FormVentas : Form
    {
        /// <summary>
        /// Constructor de la clase que inicializa una nueva instancia de la clase <see cref="FormVentas"/>.
        /// </summary>
        public FormVentas()
        {
            InitializeComponent();
        }

        /*private void ventaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ventasDataSet);

        }*/

        /// <summary>
        /// Evento Load de la clase para poner de tamaño auto las columnas y filas del DataGridView 
        /// y rellenar el TableAdapter con el DataSet que hemos creado 
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void FormVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaDeMusicaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.tiendaDeMusicaDataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDeMusicaDataSet.Disco' Puede moverla o quitarla según sea necesario.
            this.discoTableAdapter.Fill(this.tiendaDeMusicaDataSet.Disco);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDeMusicaDataSet.Instrumento' Puede moverla o quitarla según sea necesario.
            this.instrumentoTableAdapter.Fill(this.tiendaDeMusicaDataSet.Instrumento);
            // TODO: esta línea de código carga datos en la tabla 'ventasDataSet.Venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.ventasDataSet.Venta);
            // TODO: esta línea de código carga datos en la tabla 'ventasDataSet.Venta' Puede moverla o quitarla según sea necesario.
            this.ventaTableAdapter.Fill(this.ventasDataSet.Venta);

        }

        /*private void ventaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ventaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ventasDataSet);

        }*/

        /// <summary>
        /// Evento Click que permite añadir una venta
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnAnadirVenta_Click(object sender, EventArgs e)
        {
            DataRow fila = ventasDataSet.Tables["Venta"].NewRow();
            fila["idInstrumento"] = comboBoxInstrumentos.SelectedValue;
            fila["codDisco"] = comboBoxDiscos.SelectedValue;
            fila["idCliente"] = comboBoxClientes.SelectedValue;

            DateTime fechaVenta = DateTime.Parse(fechaVentaMonthCalendar.SelectionRange.Start.ToShortDateString());
            fila["fechaVenta"] = fechaVenta;
            fila["Importe Total"] = txtPrecioVenta.Text;
            ventasDataSet.Tables["Venta"].Rows.Add(fila);

            // Actualizamos el dataAdapter con el dataset de la tabla
            ventaTableAdapter.Update(ventasDataSet);

            // Actualizamos la tabla para mostrarla en el dataGridView
            ventaTableAdapter.Update(ventasDataSet);

            txtPrecioVenta.Clear();
        }

        /// <summary>
        /// Evento Click que se encarga de eliminar una venta seleccionada en el DataGridView
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnEliminarVSeleccionada_Click(object sender, EventArgs e)
        {
            ventaBindingSource.RemoveCurrent();
            ventaTableAdapter.Update(ventasDataSet);
            ventaTableAdapter.Update(ventasDataSet);
        }

        /// <summary>
        /// Evento Click que permite guardar y actualizar la información que haya cambiado de alguna venta
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnGuardarActualizar_Click(object sender, EventArgs e)
        {
            ventaBindingSource.EndEdit();
            ventaTableAdapter.Update(ventasDataSet);
            ventaTableAdapter.Fill(ventasDataSet.Venta);
        }

        /// <summary>
        /// Evento Click que permite buscar por ID del Cliente
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand();

            if(txtBCliente.Text == "")
            {
                consulta.CommandText = "SELECT * FROM Venta";
            }
            else
            {
                consulta.CommandText = "SELECT * FROM Venta WHERE idCliente";
            }

            consulta.Connection = ventaTableAdapter.Connection;
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataSet ds = new DataSet();
            da.Fill(ds, "Ventas");
            ventaDataGridView.DataSource = ds;
            ventaDataGridView.DataMember = "Ventas";
        }
    }
}
