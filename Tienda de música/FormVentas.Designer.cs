
namespace Tienda_de_música
{
    partial class FormVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            this.ventasDataSet = new Tienda_de_música.VentasDataSet();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaTableAdapter = new Tienda_de_música.VentasDataSetTableAdapters.VentaTableAdapter();
            this.tableAdapterManager = new Tienda_de_música.VentasDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxInstrumentos = new System.Windows.Forms.ComboBox();
            this.instrumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaDeMusicaDataSet = new Tienda_de_música.TiendaDeMusicaDataSet();
            this.comboBoxDiscos = new System.Windows.Forms.ComboBox();
            this.discoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrumentoTableAdapter = new Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.InstrumentoTableAdapter();
            this.discoTableAdapter = new Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.DiscoTableAdapter();
            this.clienteTableAdapter = new Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.ClienteTableAdapter();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.fechaVentaMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnAnadirVenta = new System.Windows.Forms.Button();
            this.btnEliminarVSeleccionada = new System.Windows.Forms.Button();
            this.btnGuardarActualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBCliente = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ventaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDeMusicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ventasDataSet
            // 
            this.ventasDataSet.DataSetName = "VentasDataSet";
            this.ventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "Venta";
            this.ventaBindingSource.DataSource = this.ventasDataSet;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Tienda_de_música.VentasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = this.ventaTableAdapter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Instrumento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Disco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de venta:";
            // 
            // comboBoxInstrumentos
            // 
            this.comboBoxInstrumentos.DataSource = this.instrumentoBindingSource;
            this.comboBoxInstrumentos.DisplayMember = "Nombre";
            this.comboBoxInstrumentos.FormattingEnabled = true;
            this.comboBoxInstrumentos.Location = new System.Drawing.Point(173, 25);
            this.comboBoxInstrumentos.Name = "comboBoxInstrumentos";
            this.comboBoxInstrumentos.Size = new System.Drawing.Size(170, 27);
            this.comboBoxInstrumentos.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboBoxInstrumentos, "Seleccione el instrumento que va a vender el cliente");
            this.comboBoxInstrumentos.ValueMember = "idInstrumento";
            // 
            // instrumentoBindingSource
            // 
            this.instrumentoBindingSource.DataMember = "Instrumento";
            this.instrumentoBindingSource.DataSource = this.tiendaDeMusicaDataSet;
            // 
            // tiendaDeMusicaDataSet
            // 
            this.tiendaDeMusicaDataSet.DataSetName = "TiendaDeMusicaDataSet";
            this.tiendaDeMusicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxDiscos
            // 
            this.comboBoxDiscos.DataSource = this.discoBindingSource;
            this.comboBoxDiscos.DisplayMember = "Título";
            this.comboBoxDiscos.FormattingEnabled = true;
            this.comboBoxDiscos.Location = new System.Drawing.Point(173, 71);
            this.comboBoxDiscos.Name = "comboBoxDiscos";
            this.comboBoxDiscos.Size = new System.Drawing.Size(170, 27);
            this.comboBoxDiscos.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBoxDiscos, "Seleccione el disco que el cliente vaya a vender");
            this.comboBoxDiscos.ValueMember = "codDisco";
            // 
            // discoBindingSource
            // 
            this.discoBindingSource.DataMember = "Disco";
            this.discoBindingSource.DataSource = this.tiendaDeMusicaDataSet;
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.DataSource = this.clienteBindingSource;
            this.comboBoxClientes.DisplayMember = "apellidoCliente";
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(173, 119);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(170, 27);
            this.comboBoxClientes.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBoxClientes, "Seleccione el cliente que va a realizar la venta");
            this.comboBoxClientes.ValueMember = "idCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.tiendaDeMusicaDataSet;
            // 
            // instrumentoTableAdapter
            // 
            this.instrumentoTableAdapter.ClearBeforeFill = true;
            // 
            // discoTableAdapter
            // 
            this.discoTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(173, 171);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(170, 27);
            this.txtPrecioVenta.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtPrecioVenta, "Escriba aquí el precio total de la venta");
            // 
            // fechaVentaMonthCalendar
            // 
            this.fechaVentaMonthCalendar.DataBindings.Add(new System.Windows.Forms.Binding("SelectionRange", this.ventaBindingSource, "fechaVenta", true));
            this.fechaVentaMonthCalendar.Location = new System.Drawing.Point(173, 230);
            this.fechaVentaMonthCalendar.Name = "fechaVentaMonthCalendar";
            this.fechaVentaMonthCalendar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.fechaVentaMonthCalendar, "Seleccione la fecha de la venta");
            // 
            // btnAnadirVenta
            // 
            this.btnAnadirVenta.BackColor = System.Drawing.Color.LightGreen;
            this.btnAnadirVenta.Location = new System.Drawing.Point(79, 416);
            this.btnAnadirVenta.Name = "btnAnadirVenta";
            this.btnAnadirVenta.Size = new System.Drawing.Size(164, 46);
            this.btnAnadirVenta.TabIndex = 5;
            this.btnAnadirVenta.Text = "Añadir venta";
            this.toolTip1.SetToolTip(this.btnAnadirVenta, "Pulse aquí para finalizar la venta y guardar los datos");
            this.btnAnadirVenta.UseVisualStyleBackColor = false;
            this.btnAnadirVenta.Click += new System.EventHandler(this.btnAnadirVenta_Click);
            // 
            // btnEliminarVSeleccionada
            // 
            this.btnEliminarVSeleccionada.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarVSeleccionada.Location = new System.Drawing.Point(988, 271);
            this.btnEliminarVSeleccionada.Name = "btnEliminarVSeleccionada";
            this.btnEliminarVSeleccionada.Size = new System.Drawing.Size(176, 52);
            this.btnEliminarVSeleccionada.TabIndex = 6;
            this.btnEliminarVSeleccionada.Text = "Eliminar venta seleccionada";
            this.toolTip1.SetToolTip(this.btnEliminarVSeleccionada, "Pulse aquí para eliminar la venta que haya seleccionado en la tabla");
            this.btnEliminarVSeleccionada.UseVisualStyleBackColor = false;
            this.btnEliminarVSeleccionada.Click += new System.EventHandler(this.btnEliminarVSeleccionada_Click);
            // 
            // btnGuardarActualizar
            // 
            this.btnGuardarActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarActualizar.Location = new System.Drawing.Point(1196, 271);
            this.btnGuardarActualizar.Name = "btnGuardarActualizar";
            this.btnGuardarActualizar.Size = new System.Drawing.Size(176, 52);
            this.btnGuardarActualizar.TabIndex = 7;
            this.btnGuardarActualizar.Text = "Guardar cambios y actualizar";
            this.toolTip1.SetToolTip(this.btnGuardarActualizar, "Pulse aquí para guardar los cambios y actulizar la/ venta/s que se haya actualiza" +
        "do");
            this.btnGuardarActualizar.UseVisualStyleBackColor = false;
            this.btnGuardarActualizar.Click += new System.EventHandler(this.btnGuardarActualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1056, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Buscar por Id Cliente:";
            // 
            // txtBCliente
            // 
            this.txtBCliente.Location = new System.Drawing.Point(1231, 351);
            this.txtBCliente.Name = "txtBCliente";
            this.txtBCliente.Size = new System.Drawing.Size(130, 27);
            this.txtBCliente.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtBCliente, "Escriba aquí el ID del cliente que desee buscar");
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(1154, 395);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 31);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscar, "Pulse aquí para buscar por ID cliente");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ventaDataGridView
            // 
            this.ventaDataGridView.AllowUserToAddRows = false;
            this.ventaDataGridView.AllowUserToDeleteRows = false;
            this.ventaDataGridView.AutoGenerateColumns = false;
            this.ventaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ventaDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ventaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ventaDataGridView.DataSource = this.ventaBindingSource;
            this.ventaDataGridView.Location = new System.Drawing.Point(827, 29);
            this.ventaDataGridView.Name = "ventaDataGridView";
            this.ventaDataGridView.Size = new System.Drawing.Size(637, 220);
            this.ventaDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idInstrumento";
            this.dataGridViewTextBoxColumn1.HeaderText = "idInstrumento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 132;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codDisco";
            this.dataGridViewTextBoxColumn2.HeaderText = "codDisco";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 95;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "idCliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 93;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fechaVenta";
            this.dataGridViewTextBoxColumn4.HeaderText = "fechaVenta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 111;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Importe Total";
            this.dataGridViewTextBoxColumn5.HeaderText = "Importe Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 126;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID Venta";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID Venta";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 91;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tienda_de_música.Properties.Resources.principal1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1476, 747);
            this.Controls.Add(this.ventaDataGridView);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuardarActualizar);
            this.Controls.Add(this.btnEliminarVSeleccionada);
            this.Controls.Add(this.btnAnadirVenta);
            this.Controls.Add(this.fechaVentaMonthCalendar);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.comboBoxDiscos);
            this.Controls.Add(this.comboBoxInstrumentos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDeMusicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VentasDataSet ventasDataSet;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private VentasDataSetTableAdapters.VentaTableAdapter ventaTableAdapter;
        private VentasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxInstrumentos;
        private System.Windows.Forms.ComboBox comboBoxDiscos;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private TiendaDeMusicaDataSet tiendaDeMusicaDataSet;
        private System.Windows.Forms.BindingSource instrumentoBindingSource;
        private TiendaDeMusicaDataSetTableAdapters.InstrumentoTableAdapter instrumentoTableAdapter;
        private System.Windows.Forms.BindingSource discoBindingSource;
        private TiendaDeMusicaDataSetTableAdapters.DiscoTableAdapter discoTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private TiendaDeMusicaDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.MonthCalendar fechaVentaMonthCalendar;
        private System.Windows.Forms.Button btnAnadirVenta;
        private System.Windows.Forms.Button btnEliminarVSeleccionada;
        private System.Windows.Forms.Button btnGuardarActualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView ventaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}