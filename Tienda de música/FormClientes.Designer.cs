
namespace Tienda_de_música
{
    partial class FormClientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombreClienteLabel;
            System.Windows.Forms.Label apellidoClienteLabel;
            System.Windows.Forms.Label generoFavClienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.txtNomCliente = new System.Windows.Forms.TextBox();
            this.txtApeCliente = new System.Windows.Forms.TextBox();
            this.txtGenFCliente = new System.Windows.Forms.TextBox();
            this.btnAnadirCliente = new System.Windows.Forms.Button();
            this.btnEliminarSeleccionado = new System.Windows.Forms.Button();
            this.btnGuardarActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBApellido = new System.Windows.Forms.TextBox();
            this.btnBuscarApe = new System.Windows.Forms.Button();
            this.btnBuscarGenero = new System.Windows.Forms.Button();
            this.txtBGenero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaDeMusicaDataSet = new Tienda_de_música.TiendaDeMusicaDataSet();
            this.clienteTableAdapter = new Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.TableAdapterManager();
            nombreClienteLabel = new System.Windows.Forms.Label();
            apellidoClienteLabel = new System.Windows.Forms.Label();
            generoFavClienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDeMusicaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreClienteLabel
            // 
            nombreClienteLabel.AutoSize = true;
            nombreClienteLabel.Location = new System.Drawing.Point(38, 34);
            nombreClienteLabel.Name = "nombreClienteLabel";
            nombreClienteLabel.Size = new System.Drawing.Size(119, 19);
            nombreClienteLabel.TabIndex = 1;
            nombreClienteLabel.Text = "Nombre Cliente:";
            // 
            // apellidoClienteLabel
            // 
            apellidoClienteLabel.AutoSize = true;
            apellidoClienteLabel.Location = new System.Drawing.Point(38, 80);
            apellidoClienteLabel.Name = "apellidoClienteLabel";
            apellidoClienteLabel.Size = new System.Drawing.Size(126, 19);
            apellidoClienteLabel.TabIndex = 3;
            apellidoClienteLabel.Text = "Apellidos Cliente:";
            // 
            // generoFavClienteLabel
            // 
            generoFavClienteLabel.AutoSize = true;
            generoFavClienteLabel.Location = new System.Drawing.Point(38, 129);
            generoFavClienteLabel.Name = "generoFavClienteLabel";
            generoFavClienteLabel.Size = new System.Drawing.Size(173, 19);
            generoFavClienteLabel.TabIndex = 5;
            generoFavClienteLabel.Text = "Género Favorito Cliente:";
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.clienteDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(393, 129);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.Size = new System.Drawing.Size(582, 294);
            this.clienteDataGridView.TabIndex = 1;
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(226, 31);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(138, 27);
            this.txtNomCliente.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNomCliente, "Escriba el nombre del cliente a añadir");
            // 
            // txtApeCliente
            // 
            this.txtApeCliente.Location = new System.Drawing.Point(226, 77);
            this.txtApeCliente.Name = "txtApeCliente";
            this.txtApeCliente.Size = new System.Drawing.Size(138, 27);
            this.txtApeCliente.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtApeCliente, "Escriba los apellidos del cliente a añadir");
            // 
            // txtGenFCliente
            // 
            this.txtGenFCliente.Location = new System.Drawing.Point(226, 129);
            this.txtGenFCliente.Name = "txtGenFCliente";
            this.txtGenFCliente.Size = new System.Drawing.Size(138, 27);
            this.txtGenFCliente.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtGenFCliente, "Escriba el género favorito del cliente a añadir");
            // 
            // btnAnadirCliente
            // 
            this.btnAnadirCliente.BackColor = System.Drawing.Color.LightGreen;
            this.btnAnadirCliente.Location = new System.Drawing.Point(115, 178);
            this.btnAnadirCliente.Name = "btnAnadirCliente";
            this.btnAnadirCliente.Size = new System.Drawing.Size(141, 39);
            this.btnAnadirCliente.TabIndex = 3;
            this.btnAnadirCliente.Text = "Añadir cliente";
            this.btnAnadirCliente.UseVisualStyleBackColor = false;
            this.btnAnadirCliente.Click += new System.EventHandler(this.btnAnadirCliente_Click);
            // 
            // btnEliminarSeleccionado
            // 
            this.btnEliminarSeleccionado.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarSeleccionado.Location = new System.Drawing.Point(466, 46);
            this.btnEliminarSeleccionado.Name = "btnEliminarSeleccionado";
            this.btnEliminarSeleccionado.Size = new System.Drawing.Size(184, 53);
            this.btnEliminarSeleccionado.TabIndex = 4;
            this.btnEliminarSeleccionado.Text = "Eliminar cliente seleccionado";
            this.toolTip1.SetToolTip(this.btnEliminarSeleccionado, "Pulse aquí para eliminar el cliente que haya seleccionado en la tabla");
            this.btnEliminarSeleccionado.UseVisualStyleBackColor = false;
            this.btnEliminarSeleccionado.Click += new System.EventHandler(this.btnEliminarSeleccionado_Click);
            // 
            // btnGuardarActualizar
            // 
            this.btnGuardarActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarActualizar.Location = new System.Drawing.Point(700, 46);
            this.btnGuardarActualizar.Name = "btnGuardarActualizar";
            this.btnGuardarActualizar.Size = new System.Drawing.Size(184, 53);
            this.btnGuardarActualizar.TabIndex = 5;
            this.btnGuardarActualizar.Text = "Guardar cambios y actualizar";
            this.toolTip1.SetToolTip(this.btnGuardarActualizar, "Pulse aquí para guardar y actualizar los cambios que se hayan hecho sobre un clie" +
        "nte");
            this.btnGuardarActualizar.UseVisualStyleBackColor = false;
            this.btnGuardarActualizar.Click += new System.EventHandler(this.btnGuardarActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(964, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar por apellido/s:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBApellido
            // 
            this.txtBApellido.Location = new System.Drawing.Point(1176, 46);
            this.txtBApellido.Name = "txtBApellido";
            this.txtBApellido.Size = new System.Drawing.Size(163, 27);
            this.txtBApellido.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtBApellido, "Escriba aquí el apellido/s del cliente a buscar");
            // 
            // btnBuscarApe
            // 
            this.btnBuscarApe.Location = new System.Drawing.Point(1355, 46);
            this.btnBuscarApe.Name = "btnBuscarApe";
            this.btnBuscarApe.Size = new System.Drawing.Size(104, 26);
            this.btnBuscarApe.TabIndex = 8;
            this.btnBuscarApe.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscarApe, "Pulse aquí para buscar por apellido/s del cliente");
            this.btnBuscarApe.UseVisualStyleBackColor = true;
            this.btnBuscarApe.Click += new System.EventHandler(this.btnBuscarApe_Click);
            // 
            // btnBuscarGenero
            // 
            this.btnBuscarGenero.Location = new System.Drawing.Point(1355, 89);
            this.btnBuscarGenero.Name = "btnBuscarGenero";
            this.btnBuscarGenero.Size = new System.Drawing.Size(104, 26);
            this.btnBuscarGenero.TabIndex = 9;
            this.btnBuscarGenero.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscarGenero, "Pulse aquí para buscar por género favorito del cliente");
            this.btnBuscarGenero.UseVisualStyleBackColor = true;
            this.btnBuscarGenero.Click += new System.EventHandler(this.btnBuscarGenero_Click);
            // 
            // txtBGenero
            // 
            this.txtBGenero.Location = new System.Drawing.Point(1176, 89);
            this.txtBGenero.Name = "txtBGenero";
            this.txtBGenero.Size = new System.Drawing.Size(163, 27);
            this.txtBGenero.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtBGenero, "Escriba aquí el género favorito del cliente a buscar");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(964, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Buscar por género favorito:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "idCliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 93;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombreCliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombreCliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 135;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellidoCliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "apellidoCliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 135;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "generoFavCliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "generoFavCliente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 154;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.tiendaDeMusicaDataSet;
            // 
            // tiendaDeMusicaDataSet
            // 
            this.tiendaDeMusicaDataSet.DataSetName = "TiendaDeMusicaDataSet";
            this.tiendaDeMusicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.DiscoTableAdapter = null;
            this.tableAdapterManager.InstrumentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tienda_de_música.Properties.Resources.principal1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1476, 747);
            this.Controls.Add(this.btnBuscarGenero);
            this.Controls.Add(this.txtBGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarApe);
            this.Controls.Add(this.txtBApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarActualizar);
            this.Controls.Add(this.btnEliminarSeleccionado);
            this.Controls.Add(this.btnAnadirCliente);
            this.Controls.Add(this.txtGenFCliente);
            this.Controls.Add(this.txtApeCliente);
            this.Controls.Add(this.txtNomCliente);
            this.Controls.Add(generoFavClienteLabel);
            this.Controls.Add(apellidoClienteLabel);
            this.Controls.Add(nombreClienteLabel);
            this.Controls.Add(this.clienteDataGridView);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Brown;
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDeMusicaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TiendaDeMusicaDataSet tiendaDeMusicaDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private TiendaDeMusicaDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private TiendaDeMusicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox txtNomCliente;
        private System.Windows.Forms.TextBox txtApeCliente;
        private System.Windows.Forms.TextBox txtGenFCliente;
        private System.Windows.Forms.Button btnAnadirCliente;
        private System.Windows.Forms.Button btnEliminarSeleccionado;
        private System.Windows.Forms.Button btnGuardarActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBApellido;
        private System.Windows.Forms.Button btnBuscarApe;
        private System.Windows.Forms.Button btnBuscarGenero;
        private System.Windows.Forms.TextBox txtBGenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}