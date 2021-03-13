using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_de_música
{
    public partial class FormInformes : Form
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="FormInformes"/>.
        /// </summary>
        public FormInformes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento Click que permite mostrar el informe de las transacciones de los clientes.
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void informe1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransaccionesClientesSinParam transaccionesClientes = new TransaccionesClientesSinParam();
            crystalReportViewer1.ReportSource = transaccionesClientes;
        }

        /// <summary>
        /// Evento Click que permite mostrar el informe de los beneficios.
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void beneficiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Beneficios beneficios = new Beneficios();
            crystalReportViewer1.ReportSource = beneficios;
        }

        /// <summary>
        /// Evento Click que permite mostrar el informe de las inversiones.
        /// </summary>
        /// <param name="sender">La fuente del evento</param>
        /// <param name="e">La instancia de <see cref="EventArgs"/> que contiene la información del evento</param>
        private void inversionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inversiones inversiones = new Inversiones();
            crystalReportViewer1.ReportSource = inversiones;
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.FromArgb(168, 230, 253);
        }
    }
}
