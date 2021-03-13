
namespace Tienda_de_música
{
    partial class FormInformes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informe1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beneficiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransaccionesClientes1 = new Tienda_de_música.TransaccionesClientes();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.TransaccionesClientesSinParam2 = new Tienda_de_música.TransaccionesClientesSinParam();
            this.TransaccionesClientesSinParam1 = new Tienda_de_música.TransaccionesClientesSinParam();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informe1ToolStripMenuItem,
            this.beneficiosToolStripMenuItem,
            this.inversionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1434, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informe1ToolStripMenuItem
            // 
            this.informe1ToolStripMenuItem.Name = "informe1ToolStripMenuItem";
            this.informe1ToolStripMenuItem.Size = new System.Drawing.Size(173, 23);
            this.informe1ToolStripMenuItem.Text = "Transacciones Clientes";
            this.informe1ToolStripMenuItem.Click += new System.EventHandler(this.informe1ToolStripMenuItem_Click);
            // 
            // beneficiosToolStripMenuItem
            // 
            this.beneficiosToolStripMenuItem.Name = "beneficiosToolStripMenuItem";
            this.beneficiosToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.beneficiosToolStripMenuItem.Text = "Ingresos";
            this.beneficiosToolStripMenuItem.Click += new System.EventHandler(this.beneficiosToolStripMenuItem_Click);
            // 
            // inversionesToolStripMenuItem
            // 
            this.inversionesToolStripMenuItem.Name = "inversionesToolStripMenuItem";
            this.inversionesToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.inversionesToolStripMenuItem.Text = "Inversiones";
            this.inversionesToolStripMenuItem.Click += new System.EventHandler(this.inversionesToolStripMenuItem_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 27);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.TransaccionesClientesSinParam2;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1434, 734);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 761);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.FormInformes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private TransaccionesClientesSinParam TransaccionesClientesSinParam1;
        private System.Windows.Forms.ToolStripMenuItem informe1ToolStripMenuItem;
        private TransaccionesClientes TransaccionesClientes1;
        private TransaccionesClientesSinParam TransaccionesClientesSinParam2;
        private System.Windows.Forms.ToolStripMenuItem beneficiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionesToolStripMenuItem;
    }
}