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
    public partial class FormClientes : Form
    {
        /// <summary>
        /// Constructor de la clase que inicializa los componentes
        /// </summary>
        public FormClientes()
        {
            InitializeComponent();
        }

        /*private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiendaDeMusicaDataSet);

        }*/

        /// <summary>
        /// Método Load de la clase para poner de tamaño auto las columnas y filas del DataGridView 
        /// y rellenar el TableAdapter con el DataSet que hemos creado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormClientes_Load(object sender, EventArgs e)
        {

            this.clienteDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.clienteDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // TODO: esta línea de código carga datos en la tabla 'tiendaDeMusicaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.tiendaDeMusicaDataSet.Cliente);

        }

        /// <summary>
        /// Método Click que permite añadir un cliente al DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnadirCliente_Click(object sender, EventArgs e)
        {
            DataRow fila = tiendaDeMusicaDataSet.Tables["Cliente"].NewRow();
            if (comprobarCampos())
            {
                fila["nombreCliente"] = txtNomCliente.Text;
                fila["apellidoCliente"] = txtApeCliente.Text;
                fila["generoFavCliente"] = txtGenFCliente.Text;
                tiendaDeMusicaDataSet.Tables["Cliente"].Rows.Add(fila);

                // Actualizamos el dataAdapter con el dataset de la tabla
                clienteTableAdapter.Update(tiendaDeMusicaDataSet);

                // Actualizamos la tabla para mostrarla en el dataGridView
                clienteTableAdapter.Update(tiendaDeMusicaDataSet);

                limpiarCampos();
            }
        }

        /// <summary>
        /// Método privado que comprueba que los campos obligatorios hayan sido rellenados
        /// </summary>
        /// <returns>bool bien, si todo está correcto devuelve true</returns>
        private bool comprobarCampos()
        {
            bool bien = false;

            if(txtNomCliente.Text == "")
            {
                MessageBox.Show("Introduzca el nombre del cliente para continuar, por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(txtApeCliente.Text == "")
                {
                    MessageBox.Show("Introduzca los apellidos del cliente para continuar, por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bien = true;
                }
            }

            return bien;
        }

        /// <summary>
        /// Método que permite limpiar los campos tras añadir un clienet
        /// </summary>
        private void limpiarCampos()
        {
            txtNomCliente.Clear();
            txtApeCliente.Clear();
            txtGenFCliente.Clear();
        }

        /// <summary>
        /// Evento Click que permite eliminar un cliente seleccionado en el DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {
            // Eliminamos el registro actual
            clienteBindingSource.RemoveCurrent();

            // Actualizamos el dataAdapter con el dataset de la tabla
            clienteTableAdapter.Update(tiendaDeMusicaDataSet);

            // Actualizamos la tabla para mostrarla en el dataGridView
            clienteTableAdapter.Update(tiendaDeMusicaDataSet);
        }

        /// <summary>
        /// Evento Click que permite guardar y actualizar los cambios que se hayan realizado en algún cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarActualizar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.EndEdit();
            clienteTableAdapter.Update(tiendaDeMusicaDataSet);
            clienteTableAdapter.Fill(tiendaDeMusicaDataSet.Cliente);
        }

        /// <summary>
        /// Evento Click que permite buscar un cliente por apellido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarApe_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand();
            consulta.CommandText = "SELECT * FROM Cliente WHERE apellidoCliente like '%' + @Apellido + '%'";
            consulta.Connection = clienteTableAdapter.Connection;
            consulta.Parameters.AddWithValue("@Apellido", txtBApellido.Text);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataSet ds = new DataSet();
            da.Fill(ds, "Clientes");
            clienteDataGridView.DataSource = ds;
            clienteDataGridView.DataMember = "Clientes";
        }

        /// <summary>
        /// Evento Click que permite buscar un cliente por su género favorito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarGenero_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand();
            consulta.CommandText = "SELECT * FROM Cliente WHERE generoFavCliente like '%' + @GeneroFav + '%'";
            consulta.Connection = clienteTableAdapter.Connection;
            consulta.Parameters.AddWithValue("@GeneroFav", txtBGenero.Text);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataSet ds = new DataSet();
            da.Fill(ds, "Clientes");
            clienteDataGridView.DataSource = ds;
            clienteDataGridView.DataMember = "Clientes";
        }
    }
}
