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
            this.lvHistorial = new System.Windows.Forms.ListView();
            this.tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publicacionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidadComprada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.montoOfertado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.SuspendLayout();
            // 
            // lvHistorial
            // 
            this.lvHistorial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tipo,
            this.publicacionID,
            this.fecha,
            this.cantidadComprada,
            this.montoOfertado});
            this.lvHistorial.Location = new System.Drawing.Point(273, 37);
            this.lvHistorial.Name = "lvHistorial";
            this.lvHistorial.Size = new System.Drawing.Size(578, 268);
            this.lvHistorial.TabIndex = 0;
            this.lvHistorial.UseCompatibleStateImageBehavior = false;
            this.lvHistorial.View = System.Windows.Forms.View.Details;
            // 
            // tipo
            // 
            this.tipo.Text = "Tipo";
            this.tipo.Width = 138;
            // 
            // publicacionID
            // 
            this.publicacionID.Text = "Publicación";
            this.publicacionID.Width = 95;
            // 
            // fecha
            // 
            this.fecha.Text = "Fecha";
            this.fecha.Width = 80;
            // 
            // cantidadComprada
            // 
            this.cantidadComprada.Text = "Cantidad Comprada";
            this.cantidadComprada.Width = 106;
            // 
            // montoOfertado
            // 
            this.montoOfertado.Text = "Monto Ofertado ($)";
            this.montoOfertado.Width = 133;
            // 
            // txtOperacionesSinCalificar
            // 
            this.txtOperacionesSinCalificar.Location = new System.Drawing.Point(205, 151);
            this.txtOperacionesSinCalificar.Name = "txtOperacionesSinCalificar";
            this.txtOperacionesSinCalificar.Size = new System.Drawing.Size(39, 20);
            this.txtOperacionesSinCalificar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 154);
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
            this.lvResumenCalificaciones.Location = new System.Drawing.Point(15, 37);
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
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RESUMEN DE CALIFICACIONES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "HISTORIAL DE COMPRAS/SUBASTAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calificacion promedio";
            // 
            // txtCalificacionPromedio
            // 
            this.txtCalificacionPromedio.Location = new System.Drawing.Point(205, 183);
            this.txtCalificacionPromedio.Name = "txtCalificacionPromedio";
            this.txtCalificacionPromedio.Size = new System.Drawing.Size(39, 20);
            this.txtCalificacionPromedio.TabIndex = 6;
            // 
            // txtCalificacionMasAlta
            // 
            this.txtCalificacionMasAlta.Location = new System.Drawing.Point(205, 215);
            this.txtCalificacionMasAlta.Name = "txtCalificacionMasAlta";
            this.txtCalificacionMasAlta.Size = new System.Drawing.Size(39, 20);
            this.txtCalificacionMasAlta.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calificacion mas alta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Calificacion mas baja";
            // 
            // txtCalificacionMasBaja
            // 
            this.txtCalificacionMasBaja.Location = new System.Drawing.Point(205, 246);
            this.txtCalificacionMasBaja.Name = "txtCalificacionMasBaja";
            this.txtCalificacionMasBaja.Size = new System.Drawing.Size(39, 20);
            this.txtCalificacionMasBaja.TabIndex = 10;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 318);
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
            this.Controls.Add(this.lvHistorial);
            this.Name = "frmHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvHistorial;
        private System.Windows.Forms.ColumnHeader tipo;
        private System.Windows.Forms.ColumnHeader publicacionID;
        private System.Windows.Forms.ColumnHeader fecha;
        private System.Windows.Forms.ColumnHeader cantidadComprada;
        private System.Windows.Forms.ColumnHeader montoOfertado;
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


    }
}