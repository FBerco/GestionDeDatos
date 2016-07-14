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
            this.chbComisionPublicacion = new System.Windows.Forms.CheckBox();
            this.chbVentas = new System.Windows.Forms.CheckBox();
            this.chbEnvios = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.chkMonto = new System.Windows.Forms.CheckBox();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.lblTextoPagina = new System.Windows.Forms.Label();
            this.lblPagina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsuarioVendedor
            // 
            this.cmbUsuarioVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioVendedor.FormattingEnabled = true;
            this.cmbUsuarioVendedor.Location = new System.Drawing.Point(147, 49);
            this.cmbUsuarioVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUsuarioVendedor.Name = "cmbUsuarioVendedor";
            this.cmbUsuarioVendedor.Size = new System.Drawing.Size(160, 24);
            this.cmbUsuarioVendedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha inicial";
            // 
            // txtImporteMinimo
            // 
            this.txtImporteMinimo.Enabled = false;
            this.txtImporteMinimo.Location = new System.Drawing.Point(123, 364);
            this.txtImporteMinimo.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporteMinimo.Name = "txtImporteMinimo";
            this.txtImporteMinimo.Size = new System.Drawing.Size(60, 22);
            this.txtImporteMinimo.TabIndex = 9;
            this.txtImporteMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteMinimo_KeyPress);
            // 
            // txtImporteMaximo
            // 
            this.txtImporteMaximo.Enabled = false;
            this.txtImporteMaximo.Location = new System.Drawing.Point(203, 364);
            this.txtImporteMaximo.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporteMaximo.Name = "txtImporteMaximo";
            this.txtImporteMaximo.Size = new System.Drawing.Size(60, 22);
            this.txtImporteMaximo.TabIndex = 10;
            this.txtImporteMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteMaximo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 368);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 368);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "$ ( Min - Max )";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Enabled = false;
            this.dtpFechaInicial.Location = new System.Drawing.Point(117, 274);
            this.dtpFechaInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(304, 22);
            this.dtpFechaInicial.TabIndex = 17;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Enabled = false;
            this.dtpFechaFinal.Location = new System.Drawing.Point(117, 306);
            this.dtpFechaFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(304, 22);
            this.dtpFechaFinal.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha final";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(1329, 510);
            this.shapeContainer1.TabIndex = 22;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 17;
            this.lineShape1.X2 = 312;
            this.lineShape1.Y1 = 81;
            this.lineShape1.Y2 = 81;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 16;
            this.lineShape2.X2 = 311;
            this.lineShape2.Y1 = 180;
            this.lineShape2.Y2 = 180;
            // 
            // btnListarFacturas
            // 
            this.btnListarFacturas.Location = new System.Drawing.Point(132, 429);
            this.btnListarFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarFacturas.Name = "btnListarFacturas";
            this.btnListarFacturas.Size = new System.Drawing.Size(109, 28);
            this.btnListarFacturas.TabIndex = 23;
            this.btnListarFacturas.Text = "Listar facturas";
            this.btnListarFacturas.UseVisualStyleBackColor = true;
            this.btnListarFacturas.Click += new System.EventHandler(this.btnListarFacturas_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(24, 429);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "2. SELECCIONAR LISTAR POR";
            // 
            // chbComisionPublicacion
            // 
            this.chbComisionPublicacion.AutoSize = true;
            this.chbComisionPublicacion.Location = new System.Drawing.Point(25, 155);
            this.chbComisionPublicacion.Margin = new System.Windows.Forms.Padding(4);
            this.chbComisionPublicacion.Name = "chbComisionPublicacion";
            this.chbComisionPublicacion.Size = new System.Drawing.Size(182, 21);
            this.chbComisionPublicacion.TabIndex = 38;
            this.chbComisionPublicacion.Text = "Comisión de publicación";
            this.chbComisionPublicacion.UseVisualStyleBackColor = true;
            this.chbComisionPublicacion.CheckedChanged += new System.EventHandler(this.chbComisionPublicacion_CheckedChanged);
            // 
            // chbVentas
            // 
            this.chbVentas.AutoSize = true;
            this.chbVentas.Location = new System.Drawing.Point(25, 183);
            this.chbVentas.Margin = new System.Windows.Forms.Padding(4);
            this.chbVentas.Name = "chbVentas";
            this.chbVentas.Size = new System.Drawing.Size(74, 21);
            this.chbVentas.TabIndex = 39;
            this.chbVentas.Text = "Ventas";
            this.chbVentas.UseVisualStyleBackColor = true;
            this.chbVentas.CheckedChanged += new System.EventHandler(this.chbVentas_CheckedChanged);
            // 
            // chbEnvios
            // 
            this.chbEnvios.AutoSize = true;
            this.chbEnvios.Location = new System.Drawing.Point(220, 155);
            this.chbEnvios.Margin = new System.Windows.Forms.Padding(4);
            this.chbEnvios.Name = "chbEnvios";
            this.chbEnvios.Size = new System.Drawing.Size(72, 21);
            this.chbEnvios.TabIndex = 40;
            this.chbEnvios.Text = "Envios";
            this.chbEnvios.UseVisualStyleBackColor = true;
            this.chbEnvios.CheckedChanged += new System.EventHandler(this.chbEnvios_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "1. SELECCIONAR VENDEDOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "3. SELECCIONAR FILTROS (OPCIONAL)";
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Location = new System.Drawing.Point(24, 249);
            this.chkFecha.Margin = new System.Windows.Forms.Padding(4);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(105, 21);
            this.chkFecha.TabIndex = 43;
            this.chkFecha.Text = "Filtrar fecha";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // chkMonto
            // 
            this.chkMonto.AutoSize = true;
            this.chkMonto.Location = new System.Drawing.Point(24, 343);
            this.chkMonto.Margin = new System.Windows.Forms.Padding(4);
            this.chkMonto.Name = "chkMonto";
            this.chkMonto.Size = new System.Drawing.Size(134, 21);
            this.chkMonto.TabIndex = 44;
            this.chkMonto.Text = "Filtrar por monto";
            this.chkMonto.UseVisualStyleBackColor = true;
            this.chkMonto.CheckedChanged += new System.EventHandler(this.chkMonto_CheckedChanged);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(428, 12);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowTemplate.Height = 24;
            this.dgvFacturas.Size = new System.Drawing.Size(889, 446);
            this.dgvFacturas.TabIndex = 45;
            // 
            // btnInicio
            // 
            this.btnInicio.Enabled = false;
            this.btnInicio.Location = new System.Drawing.Point(687, 464);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 34);
            this.btnInicio.TabIndex = 46;
            this.btnInicio.Text = "<<";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(768, 464);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 34);
            this.btnAnterior.TabIndex = 47;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Location = new System.Drawing.Point(954, 464);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 34);
            this.btnSiguiente.TabIndex = 48;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnFin
            // 
            this.btnFin.Enabled = false;
            this.btnFin.Location = new System.Drawing.Point(1035, 464);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(75, 34);
            this.btnFin.TabIndex = 49;
            this.btnFin.Text = ">>";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // lblTextoPagina
            // 
            this.lblTextoPagina.AutoSize = true;
            this.lblTextoPagina.Location = new System.Drawing.Point(858, 473);
            this.lblTextoPagina.Name = "lblTextoPagina";
            this.lblTextoPagina.Size = new System.Drawing.Size(52, 17);
            this.lblTextoPagina.TabIndex = 50;
            this.lblTextoPagina.Text = "Página";
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Location = new System.Drawing.Point(918, 473);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(0, 17);
            this.lblPagina.TabIndex = 51;
            // 
            // frmListadoDeFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 510);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.lblTextoPagina);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.chkMonto);
            this.Controls.Add(this.chkFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chbEnvios);
            this.Controls.Add(this.chbVentas);
            this.Controls.Add(this.chbComisionPublicacion);
            this.Controls.Add(this.label8);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListadoDeFacturas";
            this.Text = "Listado de Facturas";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
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
        private System.Windows.Forms.CheckBox chbComisionPublicacion;
        private System.Windows.Forms.CheckBox chbVentas;
        private System.Windows.Forms.CheckBox chbEnvios;
        private System.Windows.Forms.Label label9;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.CheckBox chkMonto;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Label lblTextoPagina;
        private System.Windows.Forms.Label lblPagina;
    }
}