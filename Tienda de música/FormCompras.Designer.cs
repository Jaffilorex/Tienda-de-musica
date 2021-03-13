
namespace Tienda_de_música
{
    partial class FormCompras
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
            System.Windows.Forms.Label idInstrumentoLabel;
            System.Windows.Forms.Label codDiscoLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label fechaCompraLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            this.tiendaDeMusicaDataSet = new Tienda_de_música.TiendaDeMusicaDataSet();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraTableAdapter = new Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.CompraTableAdapter();
            this.tableAdapterManager = new Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.TableAdapterManager();
            this.fechaCompraMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnAnadirCompra = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardarActualizar = new System.Windows.Forms.Button();
            this.comprasDataSet = new Tienda_de_música.ComprasDataSet();
            this.compraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.compraTableAdapter1 = new Tienda_de_música.ComprasDataSetTableAdapters.CompraTableAdapter();
            this.tableAdapterManager1 = new Tienda_de_música.ComprasDataSetTableAdapters.TableAdapterManager();
            this.txtBIdCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboBoxInstrumentos = new System.Windows.Forms.ComboBox();
            this.instrumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentoTableAdapter = new Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.InstrumentoTableAdapter();
            this.comboBoxDiscos = new System.Windows.Forms.ComboBox();
            this.discoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discoTableAdapter = new Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.DiscoTableAdapter();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.ClienteTableAdapter();
            this.compraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            idInstrumentoLabel = new System.Windows.Forms.Label();
            codDiscoLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            fechaCompraLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDeMusicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idInstrumentoLabel
            // 
            idInstrumentoLabel.AutoSize = true;
            idInstrumentoLabel.Location = new System.Drawing.Point(49, 57);
            idInstrumentoLabel.Name = "idInstrumentoLabel";
            idInstrumentoLabel.Size = new System.Drawing.Size(99, 19);
            idInstrumentoLabel.TabIndex = 1;
            idInstrumentoLabel.Text = "Instrumento:";
            // 
            // codDiscoLabel
            // 
            codDiscoLabel.AutoSize = true;
            codDiscoLabel.Location = new System.Drawing.Point(49, 113);
            codDiscoLabel.Name = "codDiscoLabel";
            codDiscoLabel.Size = new System.Drawing.Size(49, 19);
            codDiscoLabel.TabIndex = 3;
            codDiscoLabel.Text = "Disco:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(49, 170);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(60, 19);
            idClienteLabel.TabIndex = 5;
            idClienteLabel.Text = "Cliente:";
            // 
            // fechaCompraLabel
            // 
            fechaCompraLabel.AutoSize = true;
            fechaCompraLabel.Location = new System.Drawing.Point(49, 234);
            fechaCompraLabel.Name = "fechaCompraLabel";
            fechaCompraLabel.Size = new System.Drawing.Size(128, 19);
            fechaCompraLabel.TabIndex = 7;
            fechaCompraLabel.Text = "Fecha de compra:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            label1.Location = new System.Drawing.Point(902, 366);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(151, 19);
            label1.TabIndex = 15;
            label1.Text = "Buscar por ID cliente:";
            // 
            // tiendaDeMusicaDataSet
            // 
            this.tiendaDeMusicaDataSet.DataSetName = "TiendaDeMusicaDataSet";
            this.tiendaDeMusicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "Compra";
            this.compraBindingSource.DataSource = this.tiendaDeMusicaDataSet;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = this.compraTableAdapter;
            this.tableAdapterManager.DiscoTableAdapter = null;
            this.tableAdapterManager.InstrumentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // fechaCompraMonthCalendar
            // 
            this.fechaCompraMonthCalendar.DataBindings.Add(new System.Windows.Forms.Binding("SelectionRange", this.compraBindingSource, "fechaCompra", true));
            this.fechaCompraMonthCalendar.Location = new System.Drawing.Point(189, 234);
            this.fechaCompraMonthCalendar.MaxSelectionCount = 1;
            this.fechaCompraMonthCalendar.Name = "fechaCompraMonthCalendar";
            this.fechaCompraMonthCalendar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.fechaCompraMonthCalendar, "Eliga la fecha de la compra");
            // 
            // btnAnadirCompra
            // 
            this.btnAnadirCompra.BackColor = System.Drawing.Color.LightGreen;
            this.btnAnadirCompra.Location = new System.Drawing.Point(53, 425);
            this.btnAnadirCompra.Name = "btnAnadirCompra";
            this.btnAnadirCompra.Size = new System.Drawing.Size(169, 46);
            this.btnAnadirCompra.TabIndex = 4;
            this.btnAnadirCompra.Text = "Añadir compra";
            this.toolTip1.SetToolTip(this.btnAnadirCompra, "Pulse aquí para finalizar la compra");
            this.btnAnadirCompra.UseVisualStyleBackColor = false;
            this.btnAnadirCompra.Click += new System.EventHandler(this.btnAnadirCompra_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.Location = new System.Drawing.Point(847, 274);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(179, 57);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar compra seleccionada";
            this.toolTip1.SetToolTip(this.btnEliminar, "Pulse aquí para eliminar la compra que haya seleccionado en la tabla");
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardarActualizar
            // 
            this.btnGuardarActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarActualizar.Location = new System.Drawing.Point(1065, 274);
            this.btnGuardarActualizar.Name = "btnGuardarActualizar";
            this.btnGuardarActualizar.Size = new System.Drawing.Size(179, 57);
            this.btnGuardarActualizar.TabIndex = 6;
            this.btnGuardarActualizar.Text = "Guardar cambios y actualizar";
            this.toolTip1.SetToolTip(this.btnGuardarActualizar, "Pulse aquí para guardar cambios y actualizar aquella compra que haya sido cambiad" +
        "a");
            this.btnGuardarActualizar.UseVisualStyleBackColor = false;
            this.btnGuardarActualizar.Click += new System.EventHandler(this.btnGuardarActualizar_Click);
            // 
            // comprasDataSet
            // 
            this.comprasDataSet.DataSetName = "ComprasDataSet";
            this.comprasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compraBindingSource1
            // 
            this.compraBindingSource1.DataMember = "Compra";
            this.compraBindingSource1.DataSource = this.comprasDataSet;
            // 
            // compraTableAdapter1
            // 
            this.compraTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CompraTableAdapter = this.compraTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Tienda_de_música.ComprasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtBIdCliente
            // 
            this.txtBIdCliente.Location = new System.Drawing.Point(1078, 363);
            this.txtBIdCliente.Name = "txtBIdCliente";
            this.txtBIdCliente.Size = new System.Drawing.Size(100, 27);
            this.txtBIdCliente.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtBIdCliente, "Escriba aquí el ID del cliente que desee buscar");
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1004, 406);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 30);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscar, "Pulse aquí para buscar por ID del Cliente");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // comboBoxInstrumentos
            // 
            this.comboBoxInstrumentos.DataSource = this.instrumentoBindingSource;
            this.comboBoxInstrumentos.DisplayMember = "Nombre";
            this.comboBoxInstrumentos.FormattingEnabled = true;
            this.comboBoxInstrumentos.Location = new System.Drawing.Point(219, 54);
            this.comboBoxInstrumentos.Name = "comboBoxInstrumentos";
            this.comboBoxInstrumentos.Size = new System.Drawing.Size(162, 27);
            this.comboBoxInstrumentos.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboBoxInstrumentos, "Seleccione el instrumento que va a incluirse en la compra");
            this.comboBoxInstrumentos.ValueMember = "idInstrumento";
            // 
            // instrumentoBindingSource
            // 
            this.instrumentoBindingSource.DataMember = "Instrumento";
            this.instrumentoBindingSource.DataSource = this.tiendaDeMusicaDataSet;
            // 
            // instrumentoTableAdapter
            // 
            this.instrumentoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxDiscos
            // 
            this.comboBoxDiscos.DataSource = this.discoBindingSource;
            this.comboBoxDiscos.DisplayMember = "Título";
            this.comboBoxDiscos.FormattingEnabled = true;
            this.comboBoxDiscos.Location = new System.Drawing.Point(219, 110);
            this.comboBoxDiscos.Name = "comboBoxDiscos";
            this.comboBoxDiscos.Size = new System.Drawing.Size(162, 27);
            this.comboBoxDiscos.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBoxDiscos, "Seleccione el disco que va a incluirse en la compra");
            this.comboBoxDiscos.ValueMember = "codDisco";
            // 
            // discoBindingSource
            // 
            this.discoBindingSource.DataMember = "Disco";
            this.discoBindingSource.DataSource = this.tiendaDeMusicaDataSet;
            // 
            // discoTableAdapter
            // 
            this.discoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.DataSource = this.clienteBindingSource;
            this.comboBoxClientes.DisplayMember = "apellidoCliente";
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(219, 170);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(162, 27);
            this.comboBoxClientes.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBoxClientes, "Seleccione el cliente que va a realizar la compra");
            this.comboBoxClientes.ValueMember = "idCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.tiendaDeMusicaDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // compraDataGridView
            // 
            this.compraDataGridView.AllowUserToAddRows = false;
            this.compraDataGridView.AllowUserToDeleteRows = false;
            this.compraDataGridView.AutoGenerateColumns = false;
            this.compraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.compraDataGridView.DataSource = this.compraBindingSource1;
            this.compraDataGridView.Location = new System.Drawing.Point(831, 12);
            this.compraDataGridView.Name = "compraDataGridView";
            this.compraDataGridView.Size = new System.Drawing.Size(641, 220);
            this.compraDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codDisco";
            this.dataGridViewTextBoxColumn1.HeaderText = "codDisco";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fechaCompra";
            this.dataGridViewTextBoxColumn2.HeaderText = "fechaCompra";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Importe Total";
            this.dataGridViewTextBoxColumn3.HeaderText = "Importe Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "idCliente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID Compra";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID Compra";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID Instrumento";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID Instrumento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tienda_de_música.Properties.Resources.principal1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 785);
            this.Controls.Add(this.compraDataGridView);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.comboBoxDiscos);
            this.Controls.Add(this.comboBoxInstrumentos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBIdCliente);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnGuardarActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAnadirCompra);
            this.Controls.Add(fechaCompraLabel);
            this.Controls.Add(this.fechaCompraMonthCalendar);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(codDiscoLabel);
            this.Controls.Add(idInstrumentoLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.FormCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDeMusicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TiendaDeMusicaDataSet tiendaDeMusicaDataSet;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private TiendaDeMusicaDataSetTableAdapters.CompraTableAdapter compraTableAdapter;
        private TiendaDeMusicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MonthCalendar fechaCompraMonthCalendar;
        private System.Windows.Forms.Button btnAnadirCompra;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardarActualizar;
        private ComprasDataSet comprasDataSet;
        private System.Windows.Forms.BindingSource compraBindingSource1;
        private ComprasDataSetTableAdapters.CompraTableAdapter compraTableAdapter1;
        private ComprasDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox txtBIdCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox comboBoxInstrumentos;
        private System.Windows.Forms.BindingSource instrumentoBindingSource;
        private TiendaDeMusicaDataSetTableAdapters.InstrumentoTableAdapter instrumentoTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxDiscos;
        private System.Windows.Forms.BindingSource discoBindingSource;
        private TiendaDeMusicaDataSetTableAdapters.DiscoTableAdapter discoTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private TiendaDeMusicaDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridView compraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}