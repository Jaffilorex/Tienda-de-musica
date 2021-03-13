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
    public partial class FormCompras : Form
    {
        // La cadena de conexión
        private string conexionString = "Data Source=DESKTOP-LBHAM93\\SQLEXPRESS;Initial Catalog=TiendaDeMusica;Integrated Security=True";

        /// <summary>
        /// Constructor de la clase que inicializa una nueva instancia de la clase <see cref="FormCompras"/>.
        /// </summary>
        public FormCompras()
        {
            InitializeComponent();
        }

        /*private void compraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.compraBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.comprasDataSet);

        }*/

        /// <summary>
        /// Evento Load de la clase para poner de tamaño auto las columnas y filas del DataGridView 
        /// y rellenar el TableAdapter con el DataSet que hemos creado
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void FormCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaDeMusicaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.tiendaDeMusicaDataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDeMusicaDataSet.Disco' Puede moverla o quitarla según sea necesario.
            this.discoTableAdapter.Fill(this.tiendaDeMusicaDataSet.Disco);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDeMusicaDataSet.Instrumento' Puede moverla o quitarla según sea necesario.
            this.instrumentoTableAdapter.Fill(this.tiendaDeMusicaDataSet.Instrumento);
            // TODO: esta línea de código carga datos en la tabla 'comprasDataSet.Compra' Puede moverla o quitarla según sea necesario.
            this.compraTableAdapter1.Fill(this.comprasDataSet.Compra);
            this.compraDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.compraDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // TODO: esta línea de código carga datos en la tabla 'tiendaDeMusicaDataSet.Compra' Puede moverla o quitarla según sea necesario.
            this.compraTableAdapter1.Fill(this.comprasDataSet.Compra);

        }

        /// <summary>
        /// Evento Click de la clase que permite añadir una compra
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnAnadirCompra_Click(object sender, EventArgs e)
        {
            DataRow fila = comprasDataSet.Tables["Compra"].NewRow();
            
            fila["ID Instrumento"] = comboBoxInstrumentos.SelectedValue.ToString();
            fila["codDisco"] = comboBoxDiscos.SelectedValue.ToString();
            fila["idCliente"] = comboBoxClientes.SelectedValue.ToString();

            DateTime fechaCompra = DateTime.Parse(fechaCompraMonthCalendar.SelectionRange.Start.ToShortDateString());
            fila["fechaCompra"] = fechaCompra;
            fila["Importe Total"] = importeTotal();
            comprasDataSet.Tables["Compra"].Rows.Add(fila);

            // Actualizamos el dataAdapter con el dataset de la tabla
            compraTableAdapter1.Update(comprasDataSet);

            // Actualizamos la tabla para mostrarla en el dataGridView
            compraTableAdapter1.Update(comprasDataSet);

        }

        /// <summary>
        /// Método privado que saca el importe total del producto/s
        /// </summary>
        /// <returns></returns>
        private float importeTotal()
        {
            float total = 0;
            float total2 = 0;
            float Total = 0;

            if (comboBoxDiscos.SelectedValue.ToString() == "0")
            {
                //SqlCommand consulta = new SqlCommand();
                //consulta.CommandText = "SELECT Precio FROM Instrumento WHERE idInstrumento = " + Int32.Parse(txtIdInstrumento.Text);
                string sql = "SELECT Precio FROM Instrumento WHERE idInstrumento = " + comboBoxInstrumentos.SelectedValue;

                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    SqlCommand command = new SqlCommand(sql, conexion);
                    try
                    {
                        conexion.Open();
                        total = float.Parse(Convert.ToString(command.ExecuteScalar()));
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return total;
            }
            else if(comboBoxInstrumentos.SelectedValue.ToString() == "13")
            {
                /*SqlCommand consulta = new SqlCommand();
                consulta.CommandText = "SELECT Precio FROM Disco WHERE codDisco = " + Int32.Parse(txtCodDisco.Text);
                consulta.Connection = compraTableAdapter.Connection;

                total = (float)consulta.ExecuteScalar();*/


                string sql = "SELECT Precio FROM Disco WHERE codDisco = " + comboBoxDiscos.SelectedValue;

                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    SqlCommand command = new SqlCommand(sql, conexion);
                    try
                    {
                        conexion.Open();
                        total = float.Parse(Convert.ToString(command.ExecuteScalar()));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return total;
            }
            else
            {
                string sqlInstrumento = "SELECT Precio FROM Instrumento WHERE idInstrumento = " + comboBoxInstrumentos.SelectedValue;
                string sqlDisco = "SELECT Precio FROM Disco WHERE codDisco = " + comboBoxDiscos.SelectedValue;

                using (SqlConnection conexion = new SqlConnection(conexionString))
                {
                    SqlCommand command = new SqlCommand(sqlInstrumento, conexion);
                    SqlCommand command2 = new SqlCommand(sqlDisco, conexion);
                    try
                    {
                        conexion.Open();
                        total = float.Parse(Convert.ToString(command.ExecuteScalar()));

                        total2 = float.Parse(Convert.ToString(command2.ExecuteScalar()));

                        Total = total + total2;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                return Total;
            }
            return 0;
        }

        /// <summary>
        /// Evento Click que permite eliminar una compra
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Eliminamos el registro actual
            compraBindingSource1.RemoveCurrent();

            // Actualizamos el dataAdapter con el dataset de la tabla
            compraTableAdapter1.Update(comprasDataSet);

            // Actualizamos la tabla para mostrarla en el dataGridView
            compraTableAdapter1.Update(comprasDataSet);
        }

        /// <summary>
        /// Evento Click que permite guardar y actualizar la información que se haya cambiado de una compra
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnGuardarActualizar_Click(object sender, EventArgs e)
        {
            compraBindingSource1.EndEdit();
            compraTableAdapter1.Update(comprasDataSet);
            compraTableAdapter1.Fill(comprasDataSet.Compra);
        }

        /// <summary>
        /// Evento Click que permite buscar una compra por ID del Cliente
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand();

            if (txtBIdCliente.Text == "")
            {
                consulta.CommandText = "SELECT * FROM Compra";
            }
            else
            {
                consulta.CommandText = "SELECT * FROM Compra WHERE idCliente = " + Int32.Parse(txtBIdCliente.Text);
            }

            consulta.Connection = compraTableAdapter1.Connection;
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataSet ds = new DataSet();
            da.Fill(ds, "Compras");
            compraDataGridView.DataSource = ds;
            compraDataGridView.DataMember = "Compras";
        }
    }
}
