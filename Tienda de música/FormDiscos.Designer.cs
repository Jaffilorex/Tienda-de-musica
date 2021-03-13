
namespace Tienda_de_música
{
    partial class FormDiscos
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
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label familiaLabel;
            System.Windows.Forms.Label lblCodigo;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiscos));
            this.txtNumCanciones = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnEliminarSeleccionado = new System.Windows.Forms.Button();
            this.txtBTitulo = new System.Windows.Forms.TextBox();
            this.btnBuscarTitulo = new System.Windows.Forms.Button();
            this.txtBArtista = new System.Windows.Forms.TextBox();
            this.btnBuscarArtista = new System.Windows.Forms.Button();
            this.txtBGenero = new System.Windows.Forms.TextBox();
            this.btnBuscarGenero = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtDiscografia = new System.Windows.Forms.TextBox();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.discoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaDeMusicaDataSet = new Tienda_de_música.TiendaDeMusicaDataSet();
            this.discoTableAdapter = new Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.DiscoTableAdapter();
            this.tableAdapterManager = new Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.TableAdapterManager();
            this.discoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtPrecio = new System.Windows.Forms.TextBox();
            precioLabel = new System.Windows.Forms.Label();
            familiaLabel = new System.Windows.Forms.Label();
            lblCodigo = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.discoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDeMusicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            precioLabel.Location = new System.Drawing.Point(37, 102);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(114, 13);
            precioLabel.TabIndex = 28;
            precioLabel.Text = "Número de canciones:";
            // 
            // familiaLabel
            // 
            familiaLabel.AutoSize = true;
            familiaLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            familiaLabel.Location = new System.Drawing.Point(37, 70);
            familiaLabel.Name = "familiaLabel";
            familiaLabel.Size = new System.Drawing.Size(35, 13);
            familiaLabel.TabIndex = 27;
            familiaLabel.Text = "Título";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = System.Drawing.SystemColors.ScrollBar;
            lblCodigo.Location = new System.Drawing.Point(37, 34);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(43, 13);
            lblCodigo.TabIndex = 26;
            lblCodigo.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            label1.Location = new System.Drawing.Point(524, 273);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 13);
            label1.TabIndex = 34;
            label1.Text = "Buscar por título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            label2.Location = new System.Drawing.Point(524, 338);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 13);
            label2.TabIndex = 37;
            label2.Text = "Buscar por artista:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            label3.Location = new System.Drawing.Point(524, 306);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(97, 13);
            label3.TabIndex = 40;
            label3.Text = "Buscar por género:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            label4.Location = new System.Drawing.Point(37, 142);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 13);
            label4.TabIndex = 44;
            label4.Text = "Discografía:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            label5.Location = new System.Drawing.Point(37, 182);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(39, 13);
            label5.TabIndex = 46;
            label5.Text = "Artista:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            label6.Location = new System.Drawing.Point(37, 221);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(45, 13);
            label6.TabIndex = 48;
            label6.Text = "Género:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            label7.Location = new System.Drawing.Point(37, 260);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(63, 13);
            label7.TabIndex = 50;
            label7.Text = "Existencias:";
            // 
            // txtNumCanciones
            // 
            this.txtNumCanciones.Location = new System.Drawing.Point(157, 99);
            this.txtNumCanciones.Name = "txtNumCanciones";
            this.txtNumCanciones.Size = new System.Drawing.Size(100, 20);
            this.txtNumCanciones.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtNumCanciones, "Escriba el número de canciones del disco que desee añadir");
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(157, 67);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtTitulo, "Escriba el título del disco que desee añadir");
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(157, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtCodigo, "Escriba el código del disco que desee añadir");
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.LightGreen;
            this.btnAnadir.Location = new System.Drawing.Point(59, 328);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(152, 32);
            this.btnAnadir.TabIndex = 7;
            this.btnAnadir.Text = "Añadir";
            this.toolTip1.SetToolTip(this.btnAnadir, "Pulse aquí para añadir un disco");
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnEliminarSeleccionado
            // 
            this.btnEliminarSeleccionado.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarSeleccionado.Location = new System.Drawing.Point(308, 270);
            this.btnEliminarSeleccionado.Name = "btnEliminarSeleccionado";
            this.btnEliminarSeleccionado.Size = new System.Drawing.Size(153, 38);
            this.btnEliminarSeleccionado.TabIndex = 8;
            this.btnEliminarSeleccionado.Text = "Eliminar seleccionado";
            this.toolTip1.SetToolTip(this.btnEliminarSeleccionado, "Pulse aquí para eliminar el disco que haya seleccionado en la tabla");
            this.btnEliminarSeleccionado.UseVisualStyleBackColor = false;
            this.btnEliminarSeleccionado.Click += new System.EventHandler(this.btnEliminarSeleccionado_Click);
            // 
            // txtBTitulo
            // 
            this.txtBTitulo.Location = new System.Drawing.Point(629, 270);
            this.txtBTitulo.Name = "txtBTitulo";
            this.txtBTitulo.Size = new System.Drawing.Size(113, 20);
            this.txtBTitulo.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtBTitulo, "Escriba aquí el título del disco que desee buscar");
            // 
            // btnBuscarTitulo
            // 
            this.btnBuscarTitulo.Location = new System.Drawing.Point(765, 268);
            this.btnBuscarTitulo.Name = "btnBuscarTitulo";
            this.btnBuscarTitulo.Size = new System.Drawing.Size(90, 23);
            this.btnBuscarTitulo.TabIndex = 13;
            this.btnBuscarTitulo.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscarTitulo, "Pulse aquí para buscar un disco por título");
            this.btnBuscarTitulo.UseVisualStyleBackColor = true;
            this.btnBuscarTitulo.Click += new System.EventHandler(this.btnBuscarTitulo_Click);
            // 
            // txtBArtista
            // 
            this.txtBArtista.Location = new System.Drawing.Point(629, 338);
            this.txtBArtista.Name = "txtBArtista";
            this.txtBArtista.Size = new System.Drawing.Size(113, 20);
            this.txtBArtista.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtBArtista, "Escriba aquí el nombre del artista del disco que desee buscar");
            // 
            // btnBuscarArtista
            // 
            this.btnBuscarArtista.Location = new System.Drawing.Point(765, 336);
            this.btnBuscarArtista.Name = "btnBuscarArtista";
            this.btnBuscarArtista.Size = new System.Drawing.Size(90, 23);
            this.btnBuscarArtista.TabIndex = 15;
            this.btnBuscarArtista.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscarArtista, "Pulse aquí para buscar un disco por artista");
            this.btnBuscarArtista.UseVisualStyleBackColor = true;
            this.btnBuscarArtista.Click += new System.EventHandler(this.btnBuscarArtista_Click);
            // 
            // txtBGenero
            // 
            this.txtBGenero.Location = new System.Drawing.Point(629, 303);
            this.txtBGenero.Name = "txtBGenero";
            this.txtBGenero.Size = new System.Drawing.Size(113, 20);
            this.txtBGenero.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtBGenero, "Escriba aquí el género/s del disco que desee buscar");
            // 
            // btnBuscarGenero
            // 
            this.btnBuscarGenero.Location = new System.Drawing.Point(765, 304);
            this.btnBuscarGenero.Name = "btnBuscarGenero";
            this.btnBuscarGenero.Size = new System.Drawing.Size(90, 23);
            this.btnBuscarGenero.TabIndex = 14;
            this.btnBuscarGenero.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscarGenero, "Pulse aquí para buscar un disco por género");
            this.btnBuscarGenero.UseVisualStyleBackColor = true;
            this.btnBuscarGenero.Click += new System.EventHandler(this.btnBuscarGenero_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnActualizar.Location = new System.Drawing.Point(308, 320);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(153, 38);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.toolTip1.SetToolTip(this.btnActualizar, "Pulse aquí para actualizar el/los disco/s de la tabla");
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtDiscografia
            // 
            this.txtDiscografia.Location = new System.Drawing.Point(157, 139);
            this.txtDiscografia.Name = "txtDiscografia";
            this.txtDiscografia.Size = new System.Drawing.Size(100, 20);
            this.txtDiscografia.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtDiscografia, "Escriba la discografía del disco que desee añadir");
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(157, 179);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(100, 20);
            this.txtArtista.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtArtista, "Escriba el nombre del autor del disco que desee añadir");
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(157, 218);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtGenero, "Escriba el género/s del disco que desee añadir");
            // 
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(157, 257);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(100, 20);
            this.txtExistencias.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtExistencias, "Escriba el número de existencias del disco que desee añadir");
            // 
            // discoBindingSource
            // 
            this.discoBindingSource.DataMember = "Disco";
            this.discoBindingSource.DataSource = this.tiendaDeMusicaDataSet;
            // 
            // tiendaDeMusicaDataSet
            // 
            this.tiendaDeMusicaDataSet.DataSetName = "TiendaDeMusicaDataSet";
            this.tiendaDeMusicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // discoTableAdapter
            // 
            this.discoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.CompraTableAdapter = null;
            this.tableAdapterManager.DiscoTableAdapter = this.discoTableAdapter;
            this.tableAdapterManager.InstrumentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tienda_de_música.TiendaDeMusicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // discoDataGridView
            // 
            this.discoDataGridView.AllowUserToAddRows = false;
            this.discoDataGridView.AllowUserToDeleteRows = false;
            this.discoDataGridView.AutoGenerateColumns = false;
            this.discoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.discoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.discoDataGridView.DataSource = this.discoBindingSource;
            this.discoDataGridView.Location = new System.Drawing.Point(295, 31);
            this.discoDataGridView.Name = "discoDataGridView";
            this.discoDataGridView.Size = new System.Drawing.Size(677, 220);
            this.discoDataGridView.TabIndex = 51;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codDisco";
            this.dataGridViewTextBoxColumn1.HeaderText = "codDisco";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Título";
            this.dataGridViewTextBoxColumn2.HeaderText = "Título";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "numCanciones";
            this.dataGridViewTextBoxColumn3.HeaderText = "numCanciones";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Discografía";
            this.dataGridViewTextBoxColumn4.HeaderText = "Discografía";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Artista";
            this.dataGridViewTextBoxColumn5.HeaderText = "Artista";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Género";
            this.dataGridViewTextBoxColumn6.HeaderText = "Género";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Existencias";
            this.dataGridViewTextBoxColumn7.HeaderText = "Existencias";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn8.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(159, 292);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 52;
            this.toolTip1.SetToolTip(this.txtPrecio, "Escriba el precio del disco que desee añadir");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.SystemColors.ScrollBar;
            label8.Location = new System.Drawing.Point(39, 295);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(40, 13);
            label8.TabIndex = 53;
            label8.Text = "Precio:";
            // 
            // FormDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tienda_de_música.Properties.Resources.principal1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 506);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(label8);
            this.Controls.Add(this.discoDataGridView);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(label7);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(label6);
            this.Controls.Add(this.txtArtista);
            this.Controls.Add(label5);
            this.Controls.Add(this.txtDiscografia);
            this.Controls.Add(label4);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtBGenero);
            this.Controls.Add(this.btnBuscarGenero);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtBArtista);
            this.Controls.Add(this.btnBuscarArtista);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtBTitulo);
            this.Controls.Add(this.btnBuscarTitulo);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnEliminarSeleccionado);
            this.Controls.Add(this.txtNumCanciones);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(precioLabel);
            this.Controls.Add(familiaLabel);
            this.Controls.Add(lblCodigo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDiscos";
            this.Text = "Discos";
            this.Load += new System.EventHandler(this.FormDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.discoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDeMusicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TiendaDeMusicaDataSet tiendaDeMusicaDataSet;
        private System.Windows.Forms.BindingSource discoBindingSource;
        private TiendaDeMusicaDataSetTableAdapters.DiscoTableAdapter discoTableAdapter;
        private TiendaDeMusicaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtNumCanciones;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnEliminarSeleccionado;
        private System.Windows.Forms.TextBox txtBTitulo;
        private System.Windows.Forms.Button btnBuscarTitulo;
        private System.Windows.Forms.TextBox txtBArtista;
        private System.Windows.Forms.Button btnBuscarArtista;
        private System.Windows.Forms.TextBox txtBGenero;
        private System.Windows.Forms.Button btnBuscarGenero;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtDiscografia;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.DataGridView discoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtPrecio;
    }
}