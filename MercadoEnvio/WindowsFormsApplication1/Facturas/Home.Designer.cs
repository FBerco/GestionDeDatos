namespace GDD.Facturas
{
    partial class frmHome
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
            this.lbFacturas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImporteMinimo = new System.Windows.Forms.TextBox();
            this.txtImporteMaximo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbClienteQueCompro = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnListarFacturas = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.chbComisionDePublicacion = new System.Windows.Forms.CheckBox();
            this.chbVentas = new System.Windows.Forms.CheckBox();
            this.chbEnvios = new System.Windows.Forms.CheckBox();
            this.btnOKVendedor = new System.Windows.Forms.Button();
            this.btnOKFiltros = new System.Windows.Forms.Button();
            this.btnOKListarPor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbUsuarioVendedor
            // 
            this.cmbUsuarioVendedor.FormattingEnabled = true;
            this.cmbUsuarioVendedor.Location = new System.Drawing.Point(110, 26);
            this.cmbUsuarioVendedor.Name = "cmbUsuarioVendedor";
            this.cmbUsuarioVendedor.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuarioVendedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario vendedor";
            // 
            // lbFacturas
            // 
            this.lbFacturas.FormattingEnabled = true;
            this.lbFacturas.Location = new System.Drawing.Point(293, 26);
            this.lbFacturas.MultiColumn = true;
            this.lbFacturas.Name = "lbFacturas";
            this.lbFacturas.Size = new System.Drawing.Size(211, 290);
            this.lbFacturas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha inicial";
            // 
            // txtImporteMinimo
            // 
            this.txtImporteMinimo.Location = new System.Drawing.Point(87, 150);
            this.txtImporteMinimo.Name = "txtImporteMinimo";
            this.txtImporteMinimo.Size = new System.Drawing.Size(46, 20);
            this.txtImporteMinimo.TabIndex = 9;
            this.txtImporteMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteMinimo_KeyPress);
            // 
            // txtImporteMaximo
            // 
            this.txtImporteMaximo.Location = new System.Drawing.Point(147, 150);
            this.txtImporteMaximo.Name = "txtImporteMaximo";
            this.txtImporteMaximo.Size = new System.Drawing.Size(46, 20);
            this.txtImporteMaximo.TabIndex = 10;
            this.txtImporteMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteMaximo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "$";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.White;
            this.lblMin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblMin.Location = new System.Drawing.Point(99, 153);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(24, 13);
            this.lblMin.TabIndex = 13;
            this.lblMin.Text = "Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.White;
            this.lblMax.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblMax.Location = new System.Drawing.Point(157, 153);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(27, 13);
            this.lblMax.TabIndex = 14;
            this.lblMax.Text = "Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cliente";
            // 
            // cmbClienteQueCompro
            // 
            this.cmbClienteQueCompro.FormattingEnabled = true;
            this.cmbClienteQueCompro.Location = new System.Drawing.Point(87, 176);
            this.cmbClienteQueCompro.Name = "cmbClienteQueCompro";
            this.cmbClienteQueCompro.Size = new System.Drawing.Size(121, 21);
            this.cmbClienteQueCompro.TabIndex = 16;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(87, 98);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicial.TabIndex = 17;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(87, 124);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "FILTROS";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(955, 357);
            this.shapeContainer1.TabIndex = 22;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 16;
            this.lineShape2.X2 = 284;
            this.lineShape2.Y1 = 220;
            this.lineShape2.Y2 = 220;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 14;
            this.lineShape1.X2 = 284;
            this.lineShape1.Y1 = 63;
            this.lineShape1.Y2 = 63;
            // 
            // btnListarFacturas
            // 
            this.btnListarFacturas.Location = new System.Drawing.Point(151, 312);
            this.btnListarFacturas.Name = "btnListarFacturas";
            this.btnListarFacturas.Size = new System.Drawing.Size(82, 23);
            this.btnListarFacturas.TabIndex = 23;
            this.btnListarFacturas.Text = "Listar facturas";
            this.btnListarFacturas.UseVisualStyleBackColor = true;
            this.btnListarFacturas.Click += new System.EventHandler(this.btnListarFacturas_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(70, 312);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "LISTAR POR";
            // 
            // chbComisionDePublicacion
            // 
            this.chbComisionDePublicacion.AutoSize = true;
            this.chbComisionDePublicacion.Location = new System.Drawing.Point(12, 258);
            this.chbComisionDePublicacion.Name = "chbComisionDePublicacion";
            this.chbComisionDePublicacion.Size = new System.Drawing.Size(134, 17);
            this.chbComisionDePublicacion.TabIndex = 26;
            this.chbComisionDePublicacion.Text = "Comision de publiacion";
            this.chbComisionDePublicacion.UseVisualStyleBackColor = true;
            this.chbComisionDePublicacion.CheckedChanged += new System.EventHandler(this.chbComisionDePublicacion_CheckedChanged);
            // 
            // chbVentas
            // 
            this.chbVentas.AutoSize = true;
            this.chbVentas.Location = new System.Drawing.Point(12, 281);
            this.chbVentas.Name = "chbVentas";
            this.chbVentas.Size = new System.Drawing.Size(59, 17);
            this.chbVentas.TabIndex = 27;
            this.chbVentas.Text = "Ventas";
            this.chbVentas.UseVisualStyleBackColor = true;
            this.chbVentas.CheckedChanged += new System.EventHandler(this.chbVentas_CheckedChanged);
            // 
            // chbEnvios
            // 
            this.chbEnvios.AutoSize = true;
            this.chbEnvios.Location = new System.Drawing.Point(151, 258);
            this.chbEnvios.Name = "chbEnvios";
            this.chbEnvios.Size = new System.Drawing.Size(58, 17);
            this.chbEnvios.TabIndex = 28;
            this.chbEnvios.Text = "Envios";
            this.chbEnvios.UseVisualStyleBackColor = true;
            this.chbEnvios.CheckedChanged += new System.EventHandler(this.chbEnvios_CheckedChanged);
            // 
            // btnOKVendedor
            // 
            this.btnOKVendedor.Location = new System.Drawing.Point(237, 26);
            this.btnOKVendedor.Name = "btnOKVendedor";
            this.btnOKVendedor.Size = new System.Drawing.Size(31, 21);
            this.btnOKVendedor.TabIndex = 29;
            this.btnOKVendedor.Text = "OK";
            this.btnOKVendedor.UseVisualStyleBackColor = true;
            this.btnOKVendedor.Click += new System.EventHandler(this.btnOKVendedor_Click);
            // 
            // btnOKFiltros
            // 
            this.btnOKFiltros.Location = new System.Drawing.Point(237, 176);
            this.btnOKFiltros.Name = "btnOKFiltros";
            this.btnOKFiltros.Size = new System.Drawing.Size(31, 21);
            this.btnOKFiltros.TabIndex = 30;
            this.btnOKFiltros.Text = "OK";
            this.btnOKFiltros.UseVisualStyleBackColor = true;
            this.btnOKFiltros.Click += new System.EventHandler(this.btnOKFiltros_Click);
            // 
            // btnOKListarPor
            // 
            this.btnOKListarPor.Location = new System.Drawing.Point(237, 258);
            this.btnOKListarPor.Name = "btnOKListarPor";
            this.btnOKListarPor.Size = new System.Drawing.Size(31, 21);
            this.btnOKListarPor.TabIndex = 31;
            this.btnOKListarPor.Text = "OK";
            this.btnOKListarPor.UseVisualStyleBackColor = true;
            this.btnOKListarPor.Click += new System.EventHandler(this.btnOKListarPor_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 357);
            this.Controls.Add(this.btnOKListarPor);
            this.Controls.Add(this.btnOKFiltros);
            this.Controls.Add(this.btnOKVendedor);
            this.Controls.Add(this.chbEnvios);
            this.Controls.Add(this.chbVentas);
            this.Controls.Add(this.chbComisionDePublicacion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnListarFacturas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.cmbClienteQueCompro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtImporteMaximo);
            this.Controls.Add(this.txtImporteMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFacturas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsuarioVendedor);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "frmHome";
            this.Text = "Listado de Facturas";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsuarioVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbFacturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImporteMinimo;
        private System.Windows.Forms.TextBox txtImporteMaximo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbClienteQueCompro;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnListarFacturas;
        private System.Windows.Forms.Button btnLimpiar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chbComisionDePublicacion;
        private System.Windows.Forms.CheckBox chbVentas;
        private System.Windows.Forms.CheckBox chbEnvios;
        private System.Windows.Forms.Button btnOKVendedor;
        private System.Windows.Forms.Button btnOKFiltros;
        private System.Windows.Forms.Button btnOKListarPor;
    }
}