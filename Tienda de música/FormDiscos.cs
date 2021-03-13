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
    public partial class FormDiscos : Form
    {
        /// <summary>
        /// Constructor de la clase que instancia la clase <see cref="FormDiscos"/>.
        /// </summary>
        public FormDiscos()
        {
            InitializeComponent();
        }

        /*private void discoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.discoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiendaDeMusicaDataSet);

        }*/

        /// <summary>
        /// Método Load de la clase para poner de tamaño auto las columnas y filas del DataGridView 
        /// y rellenar el TableAdapter con el DataSet que hemos creado
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void FormDiscos_Load(object sender, EventArgs e)
        {
            this.discoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.discoDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            // TODO: esta línea de código carga datos en la tabla 'tiendaDeMusicaDataSet.Disco' Puede moverla o quitarla según sea necesario.
            this.discoTableAdapter.Fill(this.tiendaDeMusicaDataSet.Disco);

        }

        /// <summary>
        /// Método Click que permite añadir un disco
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            DataRow fila = tiendaDeMusicaDataSet.Tables["Disco"].NewRow();
            if (comprobarCampos())
            {
                fila["codDisco"] = txtCodigo.Text;
                fila["Título"] = txtTitulo.Text;
                fila["numCanciones"] = txtNumCanciones.Text;
                fila["Discografía"] = txtDiscografia.Text;
                fila["Artista"] = txtArtista.Text;
                fila["Género"] = txtGenero.Text;
                fila["Existencias"] = txtExistencias.Text;
                fila["Precio"] = txtPrecio.Text;
                tiendaDeMusicaDataSet.Tables["Disco"].Rows.Add(fila);

                // Actualizamos el dataAdapter con el dataset de la tabla
                discoTableAdapter.Update(tiendaDeMusicaDataSet);

                // Actualizamos la tabla para mostrarla en el dataGridView
                discoTableAdapter.Update(tiendaDeMusicaDataSet);

                limpiarCampos();
            }
            
        }

        /// <summary>
        /// Método privado para limpiar los campos tras añadir un disco
        /// </summary>
        private void limpiarCampos()
        {
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtNumCanciones.Clear();
            txtDiscografia.Clear();
            txtArtista.Clear();
            txtGenero.Clear();
            txtExistencias.Clear();
            txtPrecio.Clear();
        }

        /// <summary>
        /// Método privado para comprobar que todos los campos obligatorios están rellenados
        /// </summary>
        /// <returns>bool bien, cuando todo está correcto devuelve true</returns>
        private bool comprobarCampos()
        {
            bool bien = false;

            if(txtCodigo.Text == "")
            {
                MessageBox.Show("Introduzca el código del disco para continuar, por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(txtTitulo.Text == "")
                {
                    MessageBox.Show("Introduzca el título del disco para continuar, por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(txtNumCanciones.Text == "")
                    {
                        MessageBox.Show("Introduzca el número de canciones del disco para continuar, por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if(txtArtista.Text == "")
                        {
                            MessageBox.Show("Introduzca el nombre del artista del disco para continuar, por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if(txtGenero.Text == "")
                            {
                                MessageBox.Show("Introduzca el género del disco para continuar, por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                if(txtExistencias.Text == "")
                                {
                                    MessageBox.Show("Introduzca el número de existencias del disco para continuar, por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    if (txtPrecio.Text == "")
                                    {
                                        MessageBox.Show("Introduzca el precio del disco para continuar, por favor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        bien = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return bien;
        }

        /// <summary>
        /// Método Click que permite eliminar un disco que haya sido seleccionado en el DataGridView
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {
            // Eliminamos el registro actual
            discoBindingSource.RemoveCurrent();

            // Actualizamos el dataAdapter con el dataset de la tabla
            discoTableAdapter.Update(tiendaDeMusicaDataSet);

            // Actualizamos la tabla para mostrarla en el dataGridView
            discoTableAdapter.Update(tiendaDeMusicaDataSet);
        }

        /// <summary>
        /// Método para actualizar la info del disco o discos cuya información haya sido cambiada
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            discoBindingSource.EndEdit();
            discoTableAdapter.Update(tiendaDeMusicaDataSet);
            discoTableAdapter.Fill(tiendaDeMusicaDataSet.Disco);
        }

        /// <summary>
        /// Método Click que permite buscar un disco por su título
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnBuscarTitulo_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand();
            consulta.CommandText = "SELECT * FROM Disco WHERE Título like '%' + @Titulo + '%'";
            consulta.Connection = discoTableAdapter.Connection;
            consulta.Parameters.AddWithValue("@Titulo", txtBTitulo.Text);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataSet ds = new DataSet();
            da.Fill(ds, "Discos");
            discoDataGridView.DataSource = ds;
            discoDataGridView.DataMember = "Discos";
        }

        /// <summary>
        /// Método click que permite buscar un disco por el nombre de su artista
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnBuscarArtista_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand();
            consulta.CommandText = "SELECT * FROM Disco WHERE Artista like '%' + @Artista + '%'";
            consulta.Connection = discoTableAdapter.Connection;
            consulta.Parameters.AddWithValue("@Artista", txtBArtista.Text);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataSet ds = new DataSet();
            da.Fill(ds, "Discos");
            discoDataGridView.DataSource = ds;
            discoDataGridView.DataMember = "Discos";
        }

        /// <summary>
        /// Método click que permite buscar un disco por el género de este
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void btnBuscarGenero_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand();
            consulta.CommandText = "SELECT * FROM Disco WHERE Género like '%' + @Genero + '%'";
            consulta.Connection = discoTableAdapter.Connection;
            consulta.Parameters.AddWithValue("@Genero", txtBGenero.Text);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataSet ds = new DataSet();
            da.Fill(ds, "Discos");
            discoDataGridView.DataSource = ds;
            discoDataGridView.DataMember = "Discos";
        }

    }
}
