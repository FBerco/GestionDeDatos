namespace GDD.Generar_Publicación
{
    partial class Alta
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
            this.rbtnCompra = new System.Windows.Forms.RadioButton();
            this.rbtnSubasta = new System.Windows.Forms.RadioButton();
            this.gbPublicacion = new System.Windows.Forms.GroupBox();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbtnPublicar = new System.Windows.Forms.RadioButton();
            this.rbtnBorrador = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvRubro = new System.Windows.Forms.DataGridView();
            this.dgvVisibilidad = new System.Windows.Forms.DataGridView();
            this.gbPublicacion.SuspendLayout();
            this.gbEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisibilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnCompra
            // 
            this.rbtnCompra.AutoSize = true;
            this.rbtnCompra.Location = new System.Drawing.Point(17, 19);
            this.rbtnCompra.Name = "rbtnCompra";
            this.rbtnCompra.Size = new System.Drawing.Size(109, 17);
            this.rbtnCompra.TabIndex = 1;
            this.rbtnCompra.TabStop = true;
            this.rbtnCompra.Text = "Compra inmediata";
            this.rbtnCompra.UseVisualStyleBackColor = true;
            // 
            // rbtnSubasta
            // 
            this.rbtnSubasta.AutoSize = true;
            this.rbtnSubasta.Location = new System.Drawing.Point(17, 42);
            this.rbtnSubasta.Name = "rbtnSubasta";
            this.rbtnSubasta.Size = new System.Drawing.Size(64, 17);
            this.rbtnSubasta.TabIndex = 2;
            this.rbtnSubasta.TabStop = true;
            this.rbtnSubasta.Text = "Subasta";
            this.rbtnSubasta.UseVisualStyleBackColor = true;
            // 
            // gbPublicacion
            // 
            this.gbPublicacion.Controls.Add(this.rbtnCompra);
            this.gbPublicacion.Controls.Add(this.rbtnSubasta);
            this.gbPublicacion.Location = new System.Drawing.Point(29, 23);
            this.gbPublicacion.Name = "gbPublicacion";
            this.gbPublicacion.Size = new System.Drawing.Size(141, 77);
            this.gbPublicacion.TabIndex = 3;
            this.gbPublicacion.TabStop = false;
            this.gbPublicacion.Text = "Tipo";
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rbtnPublicar);
            this.gbEstado.Controls.Add(this.rbtnBorrador);
            this.gbEstado.Location = new System.Drawing.Point(521, 176);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(113, 69);
            this.gbEstado.TabIndex = 4;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado Publicacion";
            // 
            // rbtnPublicar
            // 
            this.rbtnPublicar.AutoSize = true;
            this.rbtnPublicar.Location = new System.Drawing.Point(8, 42);
            this.rbtnPublicar.Name = "rbtnPublicar";
            this.rbtnPublicar.Size = new System.Drawing.Size(63, 17);
            this.rbtnPublicar.TabIndex = 1;
            this.rbtnPublicar.TabStop = true;
            this.rbtnPublicar.Text = "Publicar";
            this.rbtnPublicar.UseVisualStyleBackColor = true;
            // 
            // rbtnBorrador
            // 
            this.rbtnBorrador.AutoSize = true;
            this.rbtnBorrador.Location = new System.Drawing.Point(8, 19);
            this.rbtnBorrador.Name = "rbtnBorrador";
            this.rbtnBorrador.Size = new System.Drawing.Size(65, 17);
            this.rbtnBorrador.TabIndex = 0;
            this.rbtnBorrador.TabStop = true;
            this.rbtnBorrador.Text = "Borrador";
            this.rbtnBorrador.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(254, 23);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(267, 77);
            this.txtDescripcion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(584, 63);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(50, 20);
            this.txtStock.TabIndex = 8;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(157, 120);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(221, 20);
            this.dtpFecha.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha de vencimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(584, 26);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(50, 20);
            this.txtPrecio.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rubro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Visibilidad";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(397, 358);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 44);
            this.btnConfirmar.TabIndex = 18;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(402, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "dependiendo si se quiere dar de alta o modificar una public, el text del boton ca" +
    "mbia";
            // 
            // dgvRubro
            // 
            this.dgvRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRubro.Location = new System.Drawing.Point(46, 192);
            this.dgvRubro.Name = "dgvRubro";
            this.dgvRubro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRubro.Size = new System.Drawing.Size(240, 150);
            this.dgvRubro.TabIndex = 20;
            // 
            // dgvVisibilidad
            // 
            this.dgvVisibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisibilidad.Location = new System.Drawing.Point(336, 220);
            this.dgvVisibilidad.Name = "dgvVisibilidad";
            this.dgvVisibilidad.Size = new System.Drawing.Size(61, 49);
            this.dgvVisibilidad.TabIndex = 21;
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 489);
            this.Controls.Add(this.dgvVisibilidad);
            this.Controls.Add(this.dgvRubro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.gbPublicacion);
            this.Name = "Alta";
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.Alta_Load);
            this.gbPublicacion.ResumeLayout(false);
            this.gbPublicacion.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisibilidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnCompra;
        private System.Windows.Forms.RadioButton rbtnSubasta;
        private System.Windows.Forms.GroupBox gbPublicacion;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rbtnPublicar;
        private System.Windows.Forms.RadioButton rbtnBorrador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvRubro;
        private System.Windows.Forms.DataGridView dgvVisibilidad;
    }
}