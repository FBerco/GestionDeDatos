namespace GDD.Generar_Publicación
{
    partial class frmPublicacion
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
            this.rdbCompra = new System.Windows.Forms.RadioButton();
            this.rdbSubasta = new System.Windows.Forms.RadioButton();
            this.gbPublicacion = new System.Windows.Forms.GroupBox();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rdbFinalizada = new System.Windows.Forms.RadioButton();
            this.rdbPausada = new System.Windows.Forms.RadioButton();
            this.rdbActiva = new System.Windows.Forms.RadioButton();
            this.rdbBorrador = new System.Windows.Forms.RadioButton();
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
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.cmbVisibilidad = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbPublicacion.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbCompra
            // 
            this.rdbCompra.AutoSize = true;
            this.rdbCompra.Location = new System.Drawing.Point(17, 19);
            this.rdbCompra.Name = "rdbCompra";
            this.rdbCompra.Size = new System.Drawing.Size(109, 17);
            this.rdbCompra.TabIndex = 1;
            this.rdbCompra.TabStop = true;
            this.rdbCompra.Text = "Compra inmediata";
            this.rdbCompra.UseVisualStyleBackColor = true;
            // 
            // rdbSubasta
            // 
            this.rdbSubasta.AutoSize = true;
            this.rdbSubasta.Location = new System.Drawing.Point(17, 42);
            this.rdbSubasta.Name = "rdbSubasta";
            this.rdbSubasta.Size = new System.Drawing.Size(64, 17);
            this.rdbSubasta.TabIndex = 2;
            this.rdbSubasta.TabStop = true;
            this.rdbSubasta.Text = "Subasta";
            this.rdbSubasta.UseVisualStyleBackColor = true;
            // 
            // gbPublicacion
            // 
            this.gbPublicacion.Controls.Add(this.rdbCompra);
            this.gbPublicacion.Controls.Add(this.rdbSubasta);
            this.gbPublicacion.Location = new System.Drawing.Point(15, 24);
            this.gbPublicacion.Name = "gbPublicacion";
            this.gbPublicacion.Size = new System.Drawing.Size(141, 77);
            this.gbPublicacion.TabIndex = 3;
            this.gbPublicacion.TabStop = false;
            this.gbPublicacion.Text = "Tipo";
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rdbFinalizada);
            this.gbEstado.Controls.Add(this.rdbPausada);
            this.gbEstado.Controls.Add(this.rdbActiva);
            this.gbEstado.Controls.Add(this.rdbBorrador);
            this.gbEstado.Location = new System.Drawing.Point(436, 120);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(113, 107);
            this.gbEstado.TabIndex = 4;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado Publicacion";
            // 
            // rdbFinalizada
            // 
            this.rdbFinalizada.AutoSize = true;
            this.rdbFinalizada.Location = new System.Drawing.Point(8, 84);
            this.rdbFinalizada.Name = "rdbFinalizada";
            this.rdbFinalizada.Size = new System.Drawing.Size(72, 17);
            this.rdbFinalizada.TabIndex = 3;
            this.rdbFinalizada.Text = "Finalizada";
            this.rdbFinalizada.UseVisualStyleBackColor = true;
            // 
            // rdbPausada
            // 
            this.rdbPausada.AutoSize = true;
            this.rdbPausada.Location = new System.Drawing.Point(8, 61);
            this.rdbPausada.Name = "rdbPausada";
            this.rdbPausada.Size = new System.Drawing.Size(67, 17);
            this.rdbPausada.TabIndex = 2;
            this.rdbPausada.Text = "Pausada";
            this.rdbPausada.UseVisualStyleBackColor = true;
            // 
            // rdbActiva
            // 
            this.rdbActiva.AutoSize = true;
            this.rdbActiva.Location = new System.Drawing.Point(8, 38);
            this.rdbActiva.Name = "rdbActiva";
            this.rdbActiva.Size = new System.Drawing.Size(55, 17);
            this.rdbActiva.TabIndex = 1;
            this.rdbActiva.TabStop = true;
            this.rdbActiva.Text = "Activa";
            this.rdbActiva.UseVisualStyleBackColor = true;
            // 
            // rdbBorrador
            // 
            this.rdbBorrador.AutoSize = true;
            this.rdbBorrador.Location = new System.Drawing.Point(8, 19);
            this.rdbBorrador.Name = "rdbBorrador";
            this.rdbBorrador.Size = new System.Drawing.Size(65, 17);
            this.rdbBorrador.TabIndex = 0;
            this.rdbBorrador.TabStop = true;
            this.rdbBorrador.Text = "Borrador";
            this.rdbBorrador.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(179, 43);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(267, 58);
            this.txtDescripcion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(499, 77);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(50, 20);
            this.txtStock.TabIndex = 8;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(12, 141);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(221, 20);
            this.dtpFecha.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha de vencimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio: ($)";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(519, 40);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(50, 20);
            this.txtPrecio.TabIndex = 12;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rubro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Visibilidad";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(235, 312);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 44);
            this.btnConfirmar.TabIndex = 18;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(15, 218);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(121, 21);
            this.cmbRubro.TabIndex = 19;
            // 
            // cmbVisibilidad
            // 
            this.cmbVisibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVisibilidad.FormattingEnabled = true;
            this.cmbVisibilidad.Location = new System.Drawing.Point(161, 218);
            this.cmbVisibilidad.Name = "cmbVisibilidad";
            this.cmbVisibilidad.Size = new System.Drawing.Size(121, 21);
            this.cmbVisibilidad.TabIndex = 20;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(125, 312);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 389);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbVisibilidad);
            this.Controls.Add(this.cmbRubro);
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
            this.Name = "frmPublicacion";
            this.Text = "Publicacion";
            this.gbPublicacion.ResumeLayout(false);
            this.gbPublicacion.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbCompra;
        private System.Windows.Forms.RadioButton rdbSubasta;
        private System.Windows.Forms.GroupBox gbPublicacion;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rdbActiva;
        private System.Windows.Forms.RadioButton rdbBorrador;
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
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.ComboBox cmbVisibilidad;
        private System.Windows.Forms.RadioButton rdbFinalizada;
        private System.Windows.Forms.RadioButton rdbPausada;
        private System.Windows.Forms.Button btnLimpiar;
    }
}