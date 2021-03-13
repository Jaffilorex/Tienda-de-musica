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
    public partial class FormInstrumentos : Form
    {
        /// <summary>
        /// Constructor de la clase que incializa la class <see cref="FormInstrumentos"/>.
        /// </summary>
        public FormInstrumentos()
        {
            InitializeComponent();
        }

        SqlDataAdapter adaptador = new SqlDataAdapter(); //Inicializamos un objeto SqlDataAdapter que usaremos después

        /// <summary>
        /// Método Load de la clase para poner de tamaño auto las columnas y filas del DataGridView 
        /// y rellenar el TableAdapter con el DataSet que hemos creado
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void FormInstrumentos_Load(object sender, EventArgs e)
        {
            this.instrumentoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.instrumentoDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // TODO: esta línea de código carga datos en la tabla 'tiendaDeMusicaDataSet.Instrumento' Puede moverla o quitarla según sea necesario.
            this.instrumentoTableAdapter.Fill(this.tiendaDeMusicaDataSet.Instrumento);
        }

        /// <summary>
        /// Método Click para añadir un Instrumento al DataGridView
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnAnadir_Click(object sender, EventArgs e)
        {

            DataRow fila = tiendaDeMusicaDataSet.Tables["Instrumento"].NewRow();
            if (comprobarCampos())
            {
                fila["Nombre"] = txtNombre.Text;
                fila["Familia"] = txtFamilia.Text;
                if(txtPrecio.Text == "")
                {
                    fila["Precio"] = 0;
                }
                else
                {
                    fila["Precio"] = txtPrecio.Text;
                }
                fila["Existencias"] = txtExistencias.Text;
                tiendaDeMusicaDataSet.Tables["Instrumento"].Rows.Add(fila);

                // Actualizamos el dataAdapter con el dataset de la tabla
                instrumentoTableAdapter.Update(tiendaDeMusicaDataSet);

                // Actualizamos la tabla para mostrarla en el dataGridView
                instrumentoTableAdapter.Update(tiendaDeMusicaDataSet);

                limpiarCampos();
            }

        }

        /// <summary>
        /// Método privado para limpiar los campos tras añadir un instrumento
        /// </summary>
        private void limpiarCampos()
        {
            // Limpiamos los campos
            txtNombre.Text = "";
            txtFamilia.Text = "";
            txtPrecio.Text = "";
            txtExistencias.Text = "";
        }

        /// <summary>
        /// Método privado para comprobar que se han rellenado los campos obligatorios.
        /// </summary>
        /// <returns>bool bien, que si es true indica que todo es correcto</returns>
        private bool comprobarCampos()
        {
            bool bien = false;

            if(txtNombre.Text == "")
            {
                MessageBox.Show("Introduzca el nombre del instrumento para continuar, por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(txtFamilia.Text == "")
                {
                    MessageBox.Show("Introduzca la familia del instrumento para continuar, por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(txtExistencias.Text == "")
                    {
                        MessageBox.Show("Introduzca las existencias del instrumento para continuar, por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        bien = true;
                    }
                }
            }
            return bien;
            
        }

        /// <summary>
        /// Método Click para eliminar un instrumento seleccionado en el DataGridView
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnEliminarSeleccion_Click(object sender, EventArgs e)
        {
            // Eliminamos el registro actual
            instrumentoBindingSource.RemoveCurrent();

            // Actualizamos el dataAdapter con el dataset de la tabla
            instrumentoTableAdapter.Update(tiendaDeMusicaDataSet);

            // Actualizamos la tabla para mostrarla en el dataGridView
            instrumentoTableAdapter.Update(tiendaDeMusicaDataSet);
        }

        /// <summary>
        /// Método Click para buscar un instrumento por nombre
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand();
            consulta.CommandText = "SELECT * FROM Instrumento WHERE Nombre like '%' + @Nombre + '%'";
            consulta.Connection = instrumentoTableAdapter.Connection;
            consulta.Parameters.AddWithValue("@Nombre", txtBNombre.Text);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataSet ds = new DataSet();
            da.Fill(ds, "Instrumentos");
            instrumentoDataGridView.DataSource = ds;
            instrumentoDataGridView.DataMember = "Instrumentos";
        }

        /// <summary>
        /// Método Click que permite buscar un instrumento por familia
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnBuscarFamilia_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand();
            consulta.CommandText = "SELECT * FROM Instrumento WHERE Familia like '%' + @Familia + '%'";
            consulta.Connection = instrumentoTableAdapter.Connection;
            consulta.Parameters.AddWithValue("@Familia", txtBFamilia.Text);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataSet ds = new DataSet();
            da.Fill(ds, "Instrumentos");
            instrumentoDataGridView.DataSource = ds;
            instrumentoDataGridView.DataMember = "Instrumentos";
        }

        /// <summary>
        /// Permite cambiar el texto del label al precio máximo que indique el usuario
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void txtBPrecio_TextChanged(object sender, EventArgs e)
        {
            labelBuscarPrecio.Text = "Buscar por precio máximo a " + txtBPrecio.Text + "€";
        }

        /// <summary>
        /// Método Click que permite buscar un instrumento por el precio máximo que se quiera gastar el cliente
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnBuscarPrecio_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand();

            if (txtBPrecio.Text == "")
            {
                consulta.CommandText = "SELECT * FROM Instrumento";
            }
            else
            {
                consulta.CommandText = "SELECT * FROM Instrumento WHERE Precio <= " + float.Parse(txtBPrecio.Text);
            }
            consulta.Connection = instrumentoTableAdapter.Connection;
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataSet ds = new DataSet();
            da.Fill(ds, "Instrumentos");
            instrumentoDataGridView.DataSource = ds;
            instrumentoDataGridView.DataMember = "Instrumentos";
        }

        /// <summary>
        /// Método Click que permite actualizar los datos del instrumento que haya sido cambiado
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnGuardarActualizar_Click(object sender, EventArgs e)
        {
            instrumentoBindingSource.EndEdit();
            instrumentoTableAdapter.Update(tiendaDeMusicaDataSet);
            instrumentoTableAdapter.Fill(tiendaDeMusicaDataSet.Instrumento);
        }
    }
}
