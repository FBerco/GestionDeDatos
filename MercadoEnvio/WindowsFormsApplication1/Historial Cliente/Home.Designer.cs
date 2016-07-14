namespace GDD.Historial_Cliente
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
            this.txtOperacionesSinCalificar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvResumenCalificaciones = new System.Windows.Forms.ListView();
            this.fechaCalificacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantEstrellas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalificacionPromedio = new System.Windows.Forms.TextBox();
            this.txtCalificacionMasAlta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCalificacionMasBaja = new System.Windows.Forms.TextBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.tipoElem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantComprada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantTransacciones = new System.Windows.Forms.TextBox();
            this.txtCantCompras = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantSubastas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOperacionesCalificadas = new System.Windows.Forms.TextBox();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.lblPaginaActual = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIrAPagina = new System.Windows.Forms.TextBox();
            this.btnOkIrAPagina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOperacionesSinCalificar
            // 
            this.txtOperacionesSinCalificar.Location = new System.Drawing.Point(205, 306);
            this.txtOperacionesSinCalificar.Name = "txtOperacionesSinCalificar";
            this.txtOperacionesSinCalificar.ReadOnly = true;
            this.txtOperacionesSinCalificar.Size = new System.Drawing.Size(39, 20);
            this.txtOperacionesSinCalificar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operaciones sin calificar";
            // 
            // lvResumenCalificaciones
            // 
            this.lvResumenCalificaciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fechaCalificacion,
            this.cantEstrellas});
            this.lvResumenCalificaciones.Location = new System.Drawing.Point(15, 168);
            this.lvResumenCalificaciones.Name = "lvResumenCalificaciones";
            this.lvResumenCalificaciones.Size = new System.Drawing.Size(229, 97);
            this.lvResumenCalificaciones.TabIndex = 3;
            this.lvResumenCalificaciones.UseCompatibleStateImageBehavior = false;
            this.lvResumenCalificaciones.View = System.Windows.Forms.View.Details;
            // 
            // fechaCalificacion
            // 
            this.fechaCalificacion.Text = "Fecha";
            this.fechaCalificacion.Width = 73;
            // 
            // cantEstrellas
            // 
            this.cantEstrellas.Text = "Estrellas";
            this.cantEstrellas.Width = 119;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RESUMEN DE CALIFICACIONES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "HISTORIAL DE COMPRAS/SUBASTAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calificacion promedio";
            // 
            // txtCalificacionPromedio
            // 
            this.txtCalificacionPromedio.Location = new System.Drawing.Point(205, 338);
            this.txtCalificacionPromedio.Name = "txtCalificacionPromedio";
            this.txtCalificacionPromedio.ReadOnly = true;
            this.txtCalificacionPromedio.Size = new System.Drawing.Size(39, 20);
            this.txtCalificacionPromedio.TabIndex = 6;
            // 
            // txtCalificacionMasAlta
            // 
            this.txtCalificacionMasAlta.Location = new System.Drawing.Point(205, 370);
            this.txtCalificacionMasAlta.Name = "txtCalificacionMasAlta";
            this.txtCalificacionMasAlta.ReadOnly = true;
            this.txtCalificacionMasAlta.Size = new System.Drawing.Size(39, 20);
            this.txtCalificacionMasAlta.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calificacion mas alta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Calificacion mas baja";
            // 
            // txtCalificacionMasBaja
            // 
            this.txtCalificacionMasBaja.Location = new System.Drawing.Point(205, 400);
            this.txtCalificacionMasBaja.Name = "txtCalificacionMasBaja";
            this.txtCalificacionMasBaja.ReadOnly = true;
            this.txtCalificacionMasBaja.Size = new System.Drawing.Size(39, 20);
            this.txtCalificacionMasBaja.TabIndex = 10;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoElem,
            this.publi,
            this.fechaa,
            this.cantComprada,
            this.monto});
            this.dgvHistorial.Location = new System.Drawing.Point(263, 12);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(551, 523);
            this.dgvHistorial.TabIndex = 12;
            // 
            // tipoElem
            // 
            this.tipoElem.HeaderText = "Tipo";
            this.tipoElem.Name = "tipoElem";
            this.tipoElem.ReadOnly = true;
            // 
            // publi
            // 
            this.publi.HeaderText = "Publicacion";
            this.publi.Name = "publi";
            this.publi.ReadOnly = true;
            // 
            // fechaa
            // 
            this.fechaa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaa.HeaderText = "Fecha";
            this.fechaa.Name = "fechaa";
            this.fechaa.ReadOnly = true;
            this.fechaa.Width = 62;
            // 
            // cantComprada
            // 
            this.cantComprada.HeaderText = "Cantidad Comprada";
            this.cantComprada.Name = "cantComprada";
            this.cantComprada.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto Ofertado ($)";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // txtCantTransacciones
            // 
            this.txtCantTransacciones.Location = new System.Drawing.Point(186, 38);
            this.txtCantTransacciones.Name = "txtCantTransacciones";
            this.txtCantTransacciones.ReadOnly = true;
            this.txtCantTransacciones.Size = new System.Drawing.Size(50, 20);
            this.txtCantTransacciones.TabIndex = 13;
            // 
            // txtCantCompras
            // 
            this.txtCantCompras.Location = new System.Drawing.Point(186, 89);
            this.txtCantCompras.Name = "txtCantCompras";
            this.txtCantCompras.ReadOnly = true;
            this.txtCantCompras.Size = new System.Drawing.Size(50, 20);
            this.txtCantCompras.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Transacciones (Compra/Subasta)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cantidad de compras";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cantidad de subastas";
            // 
            // txtCantSubastas
            // 
            this.txtCantSubastas.Location = new System.Drawing.Point(186, 63);
            this.txtCantSubastas.Name = "txtCantSubastas";
            this.txtCantSubastas.ReadOnly = true;
            this.txtCantSubastas.Size = new System.Drawing.Size(50, 20);
            this.txtCantSubastas.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Operaciones calificadas";
            // 
            // txtOperacionesCalificadas
            // 
            this.txtOperacionesCalificadas.Location = new System.Drawing.Point(205, 276);
            this.txtOperacionesCalificadas.Name = "txtOperacionesCalificadas";
            this.txtOperacionesCalificadas.ReadOnly = true;
            this.txtOperacionesCalificadas.Size = new System.Drawing.Size(39, 20);
            this.txtOperacionesCalificadas.TabIndex = 20;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Location = new System.Drawing.Point(496, 548);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(28, 23);
            this.btnPrevPage.TabIndex = 22;
            this.btnPrevPage.Text = "<";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(530, 548);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(28, 23);
            this.btnNextPage.TabIndex = 23;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // lblPaginaActual
            // 
            this.lblPaginaActual.AutoSize = true;
            this.lblPaginaActual.Location = new System.Drawing.Point(387, 553);
            this.lblPaginaActual.Name = "lblPaginaActual";
            this.lblPaginaActual.Size = new System.Drawing.Size(73, 13);
            this.lblPaginaActual.TabIndex = 25;
            this.lblPaginaActual.Text = "Pagina 1 de 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(563, 553);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Ir a pagina";
            // 
            // txtIrAPagina
            // 
            this.txtIrAPagina.Location = new System.Drawing.Point(626, 550);
            this.txtIrAPagina.Name = "txtIrAPagina";
            this.txtIrAPagina.Size = new System.Drawing.Size(51, 20);
            this.txtIrAPagina.TabIndex = 30;
            this.txtIrAPagina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIrAPagina_KeyPress);
            // 
            // btnOkIrAPagina
            // 
            this.btnOkIrAPagina.Location = new System.Drawing.Point(683, 549);
            this.btnOkIrAPagina.Name = "btnOkIrAPagina";
            this.btnOkIrAPagina.Size = new System.Drawing.Size(30, 23);
            this.btnOkIrAPagina.TabIndex = 31;
            this.btnOkIrAPagina.Text = "OK";
            this.btnOkIrAPagina.UseVisualStyleBackColor = true;
            this.btnOkIrAPagina.Click += new System.EventHandler(this.btnOkIrAPagina_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 588);
            this.Controls.Add(this.btnOkIrAPagina);
            this.Controls.Add(this.txtIrAPagina);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblPaginaActual);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.txtOperacionesCalificadas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCantSubastas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCantCompras);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCantTransacciones);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCalificacionMasBaja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCalificacionMasAlta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCalificacionPromedio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvResumenCalificaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOperacionesSinCalificar);
            this.Name = "frmHome";
            this.Text = "Historial Cliente";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOperacionesSinCalificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvResumenCalificaciones;
        private System.Windows.Forms.ColumnHeader fechaCalificacion;
        private System.Windows.Forms.ColumnHeader cantEstrellas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalificacionPromedio;
        private System.Windows.Forms.TextBox txtCalificacionMasAlta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCalificacionMasBaja;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.TextBox txtCantTransacciones;
        private System.Windows.Forms.TextBox txtCantCompras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantSubastas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOperacionesCalificadas;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lblPaginaActual;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIrAPagina;
        private System.Windows.Forms.Button btnOkIrAPagina;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoElem;
        private System.Windows.Forms.DataGridViewTextBoxColumn publi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantComprada;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;


    }
}