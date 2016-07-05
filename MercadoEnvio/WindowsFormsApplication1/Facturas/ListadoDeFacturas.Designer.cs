﻿namespace GDD.Facturas
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnListarFacturas = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOKVendedor = new System.Windows.Forms.Button();
            this.lvFacturas = new System.Windows.Forms.ListView();
            this.numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publicacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOKFiltros = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.chbComisionPublicacion = new System.Windows.Forms.CheckBox();
            this.chbVentas = new System.Windows.Forms.CheckBox();
            this.chbEnvios = new System.Windows.Forms.CheckBox();
            this.btnOKListarPor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha inicial";
            // 
            // txtImporteMinimo
            // 
            this.txtImporteMinimo.Location = new System.Drawing.Point(92, 245);
            this.txtImporteMinimo.Name = "txtImporteMinimo";
            this.txtImporteMinimo.Size = new System.Drawing.Size(46, 20);
            this.txtImporteMinimo.TabIndex = 9;
            this.txtImporteMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteMinimo_KeyPress);
            // 
            // txtImporteMaximo
            // 
            this.txtImporteMaximo.Location = new System.Drawing.Point(152, 245);
            this.txtImporteMaximo.Name = "txtImporteMaximo";
            this.txtImporteMaximo.Size = new System.Drawing.Size(46, 20);
            this.txtImporteMaximo.TabIndex = 10;
            this.txtImporteMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteMaximo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "$ ( Min - Max )";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(92, 193);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicial.TabIndex = 17;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(92, 219);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 172);
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
            this.shapeContainer1.Size = new System.Drawing.Size(964, 324);
            this.shapeContainer1.TabIndex = 22;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 16;
            this.lineShape2.X2 = 284;
            this.lineShape2.Y1 = 161;
            this.lineShape2.Y2 = 161;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 14;
            this.lineShape1.X2 = 284;
            this.lineShape1.Y1 = 70;
            this.lineShape1.Y2 = 70;
            // 
            // btnListarFacturas
            // 
            this.btnListarFacturas.Location = new System.Drawing.Point(151, 289);
            this.btnListarFacturas.Name = "btnListarFacturas";
            this.btnListarFacturas.Size = new System.Drawing.Size(82, 23);
            this.btnListarFacturas.TabIndex = 23;
            this.btnListarFacturas.Text = "Listar facturas";
            this.btnListarFacturas.UseVisualStyleBackColor = true;
            this.btnListarFacturas.Click += new System.EventHandler(this.btnListarFacturas_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(70, 289);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnOKVendedor
            // 
            this.btnOKVendedor.Location = new System.Drawing.Point(254, 25);
            this.btnOKVendedor.Name = "btnOKVendedor";
            this.btnOKVendedor.Size = new System.Drawing.Size(31, 21);
            this.btnOKVendedor.TabIndex = 29;
            this.btnOKVendedor.Text = "OK";
            this.btnOKVendedor.UseVisualStyleBackColor = true;
            this.btnOKVendedor.Click += new System.EventHandler(this.btnOKVendedor_Click);
            // 
            // lvFacturas
            // 
            this.lvFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numero,
            this.fecha,
            this.total,
            this.publicacion});
            this.lvFacturas.Location = new System.Drawing.Point(298, 25);
            this.lvFacturas.Name = "lvFacturas";
            this.lvFacturas.Size = new System.Drawing.Size(654, 287);
            this.lvFacturas.TabIndex = 32;
            this.lvFacturas.UseCompatibleStateImageBehavior = false;
            this.lvFacturas.View = System.Windows.Forms.View.Details;
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
            // btnOKFiltros
            // 
            this.btnOKFiltros.Location = new System.Drawing.Point(254, 244);
            this.btnOKFiltros.Name = "btnOKFiltros";
            this.btnOKFiltros.Size = new System.Drawing.Size(31, 23);
            this.btnOKFiltros.TabIndex = 36;
            this.btnOKFiltros.Text = "OK";
            this.btnOKFiltros.UseVisualStyleBackColor = true;
            this.btnOKFiltros.Click += new System.EventHandler(this.btnOKFiltros_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "LISTAR POR";
            // 
            // chbComisionPublicacion
            // 
            this.chbComisionPublicacion.AutoSize = true;
            this.chbComisionPublicacion.Location = new System.Drawing.Point(19, 110);
            this.chbComisionPublicacion.Name = "chbComisionPublicacion";
            this.chbComisionPublicacion.Size = new System.Drawing.Size(140, 17);
            this.chbComisionPublicacion.TabIndex = 38;
            this.chbComisionPublicacion.Text = "Comisión de publicación";
            this.chbComisionPublicacion.UseVisualStyleBackColor = true;
            this.chbComisionPublicacion.CheckedChanged += new System.EventHandler(this.chbComisionPublicacion_CheckedChanged);
            // 
            // chbVentas
            // 
            this.chbVentas.AutoSize = true;
            this.chbVentas.Location = new System.Drawing.Point(19, 133);
            this.chbVentas.Name = "chbVentas";
            this.chbVentas.Size = new System.Drawing.Size(59, 17);
            this.chbVentas.TabIndex = 39;
            this.chbVentas.Text = "Ventas";
            this.chbVentas.UseVisualStyleBackColor = true;
            this.chbVentas.CheckedChanged += new System.EventHandler(this.chbVentas_CheckedChanged);
            // 
            // chbEnvios
            // 
            this.chbEnvios.AutoSize = true;
            this.chbEnvios.Location = new System.Drawing.Point(165, 110);
            this.chbEnvios.Name = "chbEnvios";
            this.chbEnvios.Size = new System.Drawing.Size(58, 17);
            this.chbEnvios.TabIndex = 40;
            this.chbEnvios.Text = "Envios";
            this.chbEnvios.UseVisualStyleBackColor = true;
            this.chbEnvios.CheckedChanged += new System.EventHandler(this.chbEnvios_CheckedChanged);
            // 
            // btnOKListarPor
            // 
            this.btnOKListarPor.Location = new System.Drawing.Point(254, 110);
            this.btnOKListarPor.Name = "btnOKListarPor";
            this.btnOKListarPor.Size = new System.Drawing.Size(31, 21);
            this.btnOKListarPor.TabIndex = 41;
            this.btnOKListarPor.Text = "OK";
            this.btnOKListarPor.UseVisualStyleBackColor = true;
            this.btnOKListarPor.Click += new System.EventHandler(this.btnOKListarPor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "VENDEDOR";
            // 
            // frmListadoDeFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 324);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnOKListarPor);
            this.Controls.Add(this.chbEnvios);
            this.Controls.Add(this.chbVentas);
            this.Controls.Add(this.chbComisionPublicacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOKFiltros);
            this.Controls.Add(this.lvFacturas);
            this.Controls.Add(this.btnOKVendedor);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnListarFacturas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnListarFacturas;
        private System.Windows.Forms.Button btnLimpiar;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Button btnOKVendedor;
        private System.Windows.Forms.ListView lvFacturas;
        private System.Windows.Forms.ColumnHeader numero;
        private System.Windows.Forms.ColumnHeader fecha;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader publicacion;
        private System.Windows.Forms.Button btnOKFiltros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbComisionPublicacion;
        private System.Windows.Forms.CheckBox chbVentas;
        private System.Windows.Forms.CheckBox chbEnvios;
        private System.Windows.Forms.Button btnOKListarPor;
        private System.Windows.Forms.Label label9;
    }
}