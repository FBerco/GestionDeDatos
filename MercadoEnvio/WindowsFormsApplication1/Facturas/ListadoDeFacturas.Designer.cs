namespace GDD.Facturas
{
    partial class frmListadoDeFacturas
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
            this.cmbUsuarioVendedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImporteMinimo = new System.Windows.Forms.TextBox();
            this.txtImporteMaximo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnListarFacturas = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publicacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvFacturas = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.chkMonto = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbComisionPublicacion = new System.Windows.Forms.RadioButton();
            this.rdbEnvios = new System.Windows.Forms.RadioButton();
            this.rdbVentas = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbUsuarioVendedor
            // 
            this.cmbUsuarioVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioVendedor.FormattingEnabled = true;
            this.cmbUsuarioVendedor.Location = new System.Drawing.Point(110, 40);
            this.cmbUsuarioVendedor.Name = "cmbUsuarioVendedor";
            this.cmbUsuarioVendedor.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuarioVendedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha inicial";
            // 
            // txtImporteMinimo
            // 
            this.txtImporteMinimo.Enabled = false;
            this.txtImporteMinimo.Location = new System.Drawing.Point(92, 341);
            this.txtImporteMinimo.Name = "txtImporteMinimo";
            this.txtImporteMinimo.Size = new System.Drawing.Size(46, 20);
            this.txtImporteMinimo.TabIndex = 9;
            this.txtImporteMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteMinimo_KeyPress);
            // 
            // txtImporteMaximo
            // 
            this.txtImporteMaximo.Enabled = false;
            this.txtImporteMaximo.Location = new System.Drawing.Point(152, 341);
            this.txtImporteMaximo.Name = "txtImporteMaximo";
            this.txtImporteMaximo.Size = new System.Drawing.Size(46, 20);
            this.txtImporteMaximo.TabIndex = 10;
            this.txtImporteMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteMaximo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "$ ( Min - Max )";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Enabled = false;
            this.dtpFechaInicial.Location = new System.Drawing.Point(88, 268);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(229, 20);
            this.dtpFechaInicial.TabIndex = 17;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Enabled = false;
            this.dtpFechaFinal.Location = new System.Drawing.Point(88, 294);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(229, 20);
            this.dtpFechaFinal.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha final";
            
            // 
            // btnListarFacturas
            // 
            this.btnListarFacturas.Location = new System.Drawing.Point(99, 367);
            this.btnListarFacturas.Name = "btnListarFacturas";
            this.btnListarFacturas.Size = new System.Drawing.Size(82, 23);
            this.btnListarFacturas.TabIndex = 23;
            this.btnListarFacturas.Text = "Listar facturas";
            this.btnListarFacturas.UseVisualStyleBackColor = true;
            this.btnListarFacturas.Click += new System.EventHandler(this.btnListarFacturas_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(18, 367);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "2. SELECCIONAR LISTAR POR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "1. SELECCIONAR VENDEDOR";
            // 
            // numero
            // 
            this.numero.Text = "Número";
            this.numero.Width = 178;
            // 
            // fecha
            // 
            this.fecha.Text = "Fecha";
            this.fecha.Width = 119;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.Width = 185;
            // 
            // publicacion
            // 
            this.publicacion.Text = "Publicación ";
            this.publicacion.Width = 163;
            // 
            // lvFacturas
            // 
            this.lvFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numero,
            this.fecha,
            this.total,
            this.publicacion});
            this.lvFacturas.Location = new System.Drawing.Point(323, 15);
            this.lvFacturas.Name = "lvFacturas";
            this.lvFacturas.Size = new System.Drawing.Size(662, 319);
            this.lvFacturas.TabIndex = 32;
            this.lvFacturas.UseCompatibleStateImageBehavior = false;
            this.lvFacturas.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "3. SELECCIONAR FILTROS (OPCIONAL)";
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Location = new System.Drawing.Point(18, 247);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(81, 17);
            this.chkFecha.TabIndex = 43;
            this.chkFecha.Text = "Filtrar fecha";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // chkMonto
            // 
            this.chkMonto.AutoSize = true;
            this.chkMonto.Location = new System.Drawing.Point(18, 324);
            this.chkMonto.Name = "chkMonto";
            this.chkMonto.Size = new System.Drawing.Size(101, 17);
            this.chkMonto.TabIndex = 44;
            this.chkMonto.Text = "Filtrar por monto";
            this.chkMonto.UseVisualStyleBackColor = true;
            this.chkMonto.CheckedChanged += new System.EventHandler(this.chkMonto_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbVentas);
            this.groupBox1.Controls.Add(this.rdbEnvios);
            this.groupBox1.Controls.Add(this.rdbComisionPublicacion);
            this.groupBox1.Location = new System.Drawing.Point(16, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // rdbComisionPublicacion
            // 
            this.rdbComisionPublicacion.AutoSize = true;
            this.rdbComisionPublicacion.Checked = true;
            this.rdbComisionPublicacion.Location = new System.Drawing.Point(17, 19);
            this.rdbComisionPublicacion.Name = "rdbComisionPublicacion";
            this.rdbComisionPublicacion.Size = new System.Drawing.Size(142, 17);
            this.rdbComisionPublicacion.TabIndex = 0;
            this.rdbComisionPublicacion.TabStop = true;
            this.rdbComisionPublicacion.Text = "Comisión por publicación";
            this.rdbComisionPublicacion.UseVisualStyleBackColor = true;
            // 
            // rdbEnvios
            // 
            this.rdbEnvios.AutoSize = true;
            this.rdbEnvios.Location = new System.Drawing.Point(17, 42);
            this.rdbEnvios.Name = "rdbEnvios";
            this.rdbEnvios.Size = new System.Drawing.Size(59, 17);
            this.rdbEnvios.TabIndex = 1;
            this.rdbEnvios.Text = "Envíos";
            this.rdbEnvios.UseVisualStyleBackColor = true;
            // 
            // rdbVentas
            // 
            this.rdbVentas.AutoSize = true;
            this.rdbVentas.Location = new System.Drawing.Point(17, 65);
            this.rdbVentas.Name = "rdbVentas";
            this.rdbVentas.Size = new System.Drawing.Size(58, 17);
            this.rdbVentas.TabIndex = 2;
            this.rdbVentas.Text = "Ventas";
            this.rdbVentas.UseVisualStyleBackColor = true;
            // 
            // frmListadoDeFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 434);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkMonto);
            this.Controls.Add(this.chkFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvFacturas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnListarFacturas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtImporteMaximo);
            this.Controls.Add(this.txtImporteMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsuarioVendedor);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "frmListadoDeFacturas";
            this.Text = "Listado de Facturas";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsuarioVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImporteMinimo;
        private System.Windows.Forms.TextBox txtImporteMaximo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button btnListarFacturas;
        private System.Windows.Forms.Button btnLimpiar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader numero;
        private System.Windows.Forms.ColumnHeader fecha;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader publicacion;
        private System.Windows.Forms.ListView lvFacturas;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.CheckBox chkMonto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbVentas;
        private System.Windows.Forms.RadioButton rdbEnvios;
        private System.Windows.Forms.RadioButton rdbComisionPublicacion;
    }
}