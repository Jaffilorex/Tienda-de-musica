
namespace Tienda_de_música
{
    partial class FormInstrumentos
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label familiaLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstrumentos));
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnEliminarSeleccion = new System.Windows.Forms.Button();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.txtBNombre = new System.Windows.Forms.TextBox();
            this.txtBFamilia = new System.Windows.Forms.TextBox();
            this.btnBuscarFamilia = new System.Windows.Forms.Button();
            this.txtBPrecio = new System.Windows.Forms.TextBox();
            this.btnBuscarPrecio = new System.Windows.Forms.Button();
            this.labelBuscarPrecio = new System.Windows.Forms.Label();
            this.btnGuardarActualizar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFamilia = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.instrumentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaDeMusicaDataSet = new Tienda_de_música.TiendaDeMusicaDataSet();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.instrumentoTableAdapter = new Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.InstrumentoTableAdapter();
            this.tableAdapterManager = new Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.TableAdapterManager();
            nombreLabel = new System.Windows.Forms.Label();
            familiaLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDeMusicaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(27, 48);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // familiaLabel
            // 
            familiaLabel.AutoSize = true;
            familiaLabel.Location = new System.Drawing.Point(27, 79);
            familiaLabel.Name = "familiaLabel";
            familiaLabel.Size = new System.Drawing.Size(42, 13);
            familiaLabel.TabIndex = 5;
            familiaLabel.Text = "Familia:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(29, 111);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 7;
            precioLabel.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(551, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 13);
            label1.TabIndex = 11;
            label1.Text = "Buscar por nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(551, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 13);
            label2.TabIndex = 15;
            label2.Text = "Buscar por familia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(27, 146);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 13);
            label3.TabIndex = 26;
            label3.Text = "Existencias:";
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.LightGreen;
            this.btnAnadir.Location = new System.Drawing.Point(30, 185);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(152, 32);
            this.btnAnadir.TabIndex = 4;
            this.btnAnadir.Text = "Añadir";
            this.toolTip1.SetToolTip(this.btnAnadir, "Pulse aquí para añadir el instrumento");
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnEliminarSeleccion
            // 
            this.btnEliminarSeleccion.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarSeleccion.Location = new System.Drawing.Point(275, 27);
            this.btnEliminarSeleccion.Name = "btnEliminarSeleccion";
            this.btnEliminarSeleccion.Size = new System.Drawing.Size(108, 54);
            this.btnEliminarSeleccion.TabIndex = 5;
            this.btnEliminarSeleccion.Text = "Eliminar seleccionado";
            this.toolTip1.SetToolTip(this.btnEliminarSeleccion, "Pulse aquí para eliminar el instrumento que haya seleccionado en la tabla");
            this.btnEliminarSeleccion.UseVisualStyleBackColor = false;
            this.btnEliminarSeleccion.Click += new System.EventHandler(this.btnEliminarSeleccion_Click);
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Location = new System.Drawing.Point(867, 12);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(90, 23);
            this.btnBuscarNombre.TabIndex = 10;
            this.btnBuscarNombre.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscarNombre, "Pulse aquí para buscar por nombre");
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // txtBNombre
            // 
            this.txtBNombre.Location = new System.Drawing.Point(718, 14);
            this.txtBNombre.Name = "txtBNombre";
            this.txtBNombre.Size = new System.Drawing.Size(113, 20);
            this.txtBNombre.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtBNombre, "Escriba aquí el nombre del instrumento que desee buscar");
            // 
            // txtBFamilia
            // 
            this.txtBFamilia.Location = new System.Drawing.Point(718, 72);
            this.txtBFamilia.Name = "txtBFamilia";
            this.txtBFamilia.Size = new System.Drawing.Size(113, 20);
            this.txtBFamilia.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtBFamilia, "Escriba aquí la familia del instrumento que desee buscar");
            // 
            // btnBuscarFamilia
            // 
            this.btnBuscarFamilia.Location = new System.Drawing.Point(867, 74);
            this.btnBuscarFamilia.Name = "btnBuscarFamilia";
            this.btnBuscarFamilia.Size = new System.Drawing.Size(90, 23);
            this.btnBuscarFamilia.TabIndex = 12;
            this.btnBuscarFamilia.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscarFamilia, "Pulse aquí para buscar por familia");
            this.btnBuscarFamilia.UseVisualStyleBackColor = true;
            this.btnBuscarFamilia.Click += new System.EventHandler(this.btnBuscarFamilia_Click);
            // 
            // txtBPrecio
            // 
            this.txtBPrecio.Location = new System.Drawing.Point(718, 45);
            this.txtBPrecio.Name = "txtBPrecio";
            this.txtBPrecio.Size = new System.Drawing.Size(113, 20);
            this.txtBPrecio.TabIndex = 8;
            this.txtBPrecio.Text = "0";
            this.toolTip1.SetToolTip(this.txtBPrecio, "Escriba aquí el precio máximo del instrumento que desee buscar");
            this.txtBPrecio.TextChanged += new System.EventHandler(this.txtBPrecio_TextChanged);
            // 
            // btnBuscarPrecio
            // 
            this.btnBuscarPrecio.Location = new System.Drawing.Point(867, 43);
            this.btnBuscarPrecio.Name = "btnBuscarPrecio";
            this.btnBuscarPrecio.Size = new System.Drawing.Size(90, 23);
            this.btnBuscarPrecio.TabIndex = 11;
            this.btnBuscarPrecio.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscarPrecio, "Pulse aquí para buscar por precio máximo");
            this.btnBuscarPrecio.UseVisualStyleBackColor = true;
            this.btnBuscarPrecio.Click += new System.EventHandler(this.btnBuscarPrecio_Click);
            // 
            // labelBuscarPrecio
            // 
            this.labelBuscarPrecio.AutoSize = true;
            this.labelBuscarPrecio.Location = new System.Drawing.Point(551, 48);
            this.labelBuscarPrecio.Name = "labelBuscarPrecio";
            this.labelBuscarPrecio.Size = new System.Drawing.Size(152, 13);
            this.labelBuscarPrecio.TabIndex = 21;
            this.labelBuscarPrecio.Text = "Buscar por precio máximo a 0€";
            // 
            // btnGuardarActualizar
            // 
            this.btnGuardarActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarActualizar.Location = new System.Drawing.Point(398, 27);
            this.btnGuardarActualizar.Name = "btnGuardarActualizar";
            this.btnGuardarActualizar.Size = new System.Drawing.Size(108, 54);
            this.btnGuardarActualizar.TabIndex = 6;
            this.btnGuardarActualizar.Text = "Guardar cambios y Actualizar";
            this.toolTip1.SetToolTip(this.btnGuardarActualizar, "Pulse aquí para guardar los cambios que haya realizado en la tabla y actualizarlo" +
        "s");
            this.btnGuardarActualizar.UseVisualStyleBackColor = false;
            this.btnGuardarActualizar.Click += new System.EventHandler(this.btnGuardarActualizar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtNombre, "Escriba el nombre del instrumento que desee añadir");
            // 
            // txtFamilia
            // 
            this.txtFamilia.Location = new System.Drawing.Point(96, 76);
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.Size = new System.Drawing.Size(100, 20);
            this.txtFamilia.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtFamilia, "Escriba la familia del instrumento que desee añadir");
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(96, 108);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtPrecio, "Escriba el precio del instrumento que desee añadir");
            // 
            // instrumentoDataGridView
            // 
            this.instrumentoDataGridView.AllowUserToAddRows = false;
            this.instrumentoDataGridView.AllowUserToDeleteRows = false;
            this.instrumentoDataGridView.AutoGenerateColumns = false;
            this.instrumentoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.instrumentoDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.instrumentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instrumentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.instrumentoDataGridView.DataSource = this.instrumentoBindingSource;
            this.instrumentoDataGridView.Location = new System.Drawing.Point(275, 111);
            this.instrumentoDataGridView.Name = "instrumentoDataGridView";
            this.instrumentoDataGridView.Size = new System.Drawing.Size(417, 220);
            this.instrumentoDataGridView.TabIndex = 25;
            this.toolTip1.SetToolTip(this.instrumentoDataGridView, "Aquí puede ver los diferentes instrumentos que hay en la tienda");
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idInstrumento";
            this.dataGridViewTextBoxColumn1.HeaderText = "idInstrumento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 95;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 69;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Familia";
            this.dataGridViewTextBoxColumn3.HeaderText = "Familia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 64;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 62;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Existencias";
            this.dataGridViewTextBoxColumn5.HeaderText = "Existencias";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 85;
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
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(96, 143);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(100, 20);
            this.txtExistencias.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtExistencias, "Escriba el número de existencias del instrumento que desee añadir");
            // 
            // instrumentoTableAdapter
            // 
            this.instrumentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.DiscoTableAdapter = null;
            this.tableAdapterManager.InstrumentoTableAdapter = this.instrumentoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // FormInstrumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tienda_de_música.Properties.Resources.principal1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(label3);
            this.Controls.Add(this.instrumentoDataGridView);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtFamilia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnGuardarActualizar);
            this.Controls.Add(this.labelBuscarPrecio);
            this.Controls.Add(this.txtBPrecio);
            this.Controls.Add(this.btnBuscarPrecio);
            this.Controls.Add(this.txtBFamilia);
            this.Controls.Add(this.btnBuscarFamilia);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtBNombre);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnEliminarSeleccion);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(precioLabel);
            this.Controls.Add(familiaLabel);
            this.Controls.Add(nombreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInstrumentos";
            this.Text = "Instrumentos";
            this.Load += new System.EventHandler(this.FormInstrumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instrumentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDeMusicaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TiendaDeMusicaDataSet tiendaDeMusicaDataSet;
        private System.Windows.Forms.BindingSource instrumentoBindingSource;
        private TiendaDeMusicaDataSetTableAdapters.InstrumentoTableAdapter instrumentoTableAdapter;
        private TiendaDeMusicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnEliminarSeleccion;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.TextBox txtBNombre;
        private System.Windows.Forms.TextBox txtBFamilia;
        private System.Windows.Forms.Button btnBuscarFamilia;
        private System.Windows.Forms.TextBox txtBPrecio;
        private System.Windows.Forms.Button btnBuscarPrecio;
        private System.Windows.Forms.Label labelBuscarPrecio;
        private System.Windows.Forms.Button btnGuardarActualizar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridView instrumentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox txtExistencias;
    }
}