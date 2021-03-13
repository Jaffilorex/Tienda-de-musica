using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tienda_de_música
{
    public partial class FormPrincipal : System.Windows.Forms.Form
    {
        /// <summary>
        /// Constructor de la clase que permite iniciar el SplashScreen
        /// </summary>
        public FormPrincipal()
        {

            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();
        }

        /// <summary>
        /// Método para iniciar el SplashScreen
        /// </summary>
        public void SplashStart()
        {
            Application.Run(new Splash());
        }

        /// <summary>
        /// Tick del Timer para actualizar tanto la fecha como la hora al segundo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelFecha.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        /// <summary>
        /// Método Load del Formulario para activar el Timer y cambiar el color de fondo del menú y del StatusStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            menuStrip1.BackColor = Color.FromArgb(168, 230, 253);
            statusStrip1.BackColor = Color.FromArgb(168, 230, 253);

        }

        /// <summary>
        /// Método click para iniciar el formulario de Discos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void discosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDiscos discos = new FormDiscos();
            discos.MdiParent = this;
            discos.Show();
        }

        /// <summary>
        /// Método click para iniciar el formulario de Instrumentos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void instrumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInstrumentos instrumentos = new FormInstrumentos();
            instrumentos.MdiParent = this;
            instrumentos.Show();
        }

        /// <summary>
        /// Método Click para mostrar el formulario de Clientes
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes clientes = new FormClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        /// <summary>
        /// Método click para iniciar el formulario de Compras
        /// </summary>
        /// <param name="sender">La fuente del evento.</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCompras compras = new FormCompras();
            compras.MdiParent = this;
            compras.Show();
        }

        /// <summary>
        /// Método click para iniciar el formulario de Ventas
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void ventasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormVentas ventas = new FormVentas();
            ventas.MdiParent = this;
            ventas.Show();
        }

        /// <summary>
        /// Método click para iniciar el formulario de Informes
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInformes informes = new FormInformes();
            //informes.MdiParent = this;
            informes.Show();
        }

        /// <summary>
        /// Método Click para mostrar una ventana con una información general sobre el programa
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa permite gestionar una tienda de música pudiendo añadir, editar, actualizar y eliminar tanto discos " +
                "como instrumentos, clientes, compras y ventas.\nAdemás permite crear informes " +
                "sobre las ventas y compras que se han producido en la tienda con sus respectivos ingresos y " +
                "buscar las compras o ventas que haya realizado un cliente.", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Método Click que nos permite salir del programa, no sin antes preguntando para evitar una salida no deseada.
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro de que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void documentaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = System.IO.Directory.GetCurrentDirectory();
            System.Diagnostics.Process.Start(ruta + "\\Documentation.chm");
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = System.IO.Directory.GetCurrentDirectory();
            System.Diagnostics.Process.Start(ruta + "\\Tienda de Música.chm");
        }
    }
}
