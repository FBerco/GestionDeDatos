namespace GDD.ABM_Visibilidad
{
    partial class frmModificar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComisionXTipoPublicacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComisionXProductoVendido = new System.Windows.Forms.TextBox();
            this.txtComisionXEnvioProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNombreVisibilidad = new System.Windows.Forms.ComboBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.chbTieneEnvio = new System.Windows.Forms.CheckBox();
            this.btnOKVisibilidad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de visibilidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comisión por tipo de publicación ($)";
            // 
            // txtComisionXTipoPublicacion
            // 
            this.txtComisionXTipoPublicacion.Location = new System.Drawing.Point(243, 60);
            this.txtComisionXTipoPublicacion.MaxLength = 6;
            this.txtComisionXTipoPublicacion.Name = "txtComisionXTipoPublicacion";
            this.txtComisionXTipoPublicacion.Size = new System.Drawing.Size(100, 20);
            this.txtComisionXTipoPublicacion.TabIndex = 3;
            this.txtComisionXTipoPublicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComisionXTipoPublicacion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comisión por producto vendido (%)";
            // 
            // txtComisionXProductoVendido
            // 
            this.txtComisionXProductoVendido.Location = new System.Drawing.Point(243, 91);
            this.txtComisionXProductoVendido.MaxLength = 3;
            this.txtComisionXProductoVendido.Name = "txtComisionXProductoVendido";
            this.txtComisionXProductoVendido.Size = new System.Drawing.Size(100, 20);
            this.txtComisionXProductoVendido.TabIndex = 3;
            this.txtComisionXProductoVendido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComisionXProductoVendido_KeyPress);
            // 
            // txtComisionXEnvioProducto
            // 
            this.txtComisionXEnvioProducto.Location = new System.Drawing.Point(242, 141);
            this.txtComisionXEnvioProducto.MaxLength = 6;
            this.txtComisionXEnvioProducto.Name = "txtComisionXEnvioProducto";
            this.txtComisionXEnvioProducto.Size = new System.Drawing.Size(100, 20);
            this.txtComisionXEnvioProducto.TabIndex = 6;
            this.txtComisionXEnvioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComisionXEnvioProducto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Comisión por envío del producto ($)";
            // 
            // cmbNombreVisibilidad
            // 
            this.cmbNombreVisibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreVisibilidad.FormattingEnabled = true;
            this.cmbNombreVisibilidad.Location = new System.Drawing.Point(243, 27);
            this.cmbNombreVisibilidad.Name = "cmbNombreVisibilidad";
            this.cmbNombreVisibilidad.Size = new System.Drawing.Size(100, 21);
            this.cmbNombreVisibilidad.TabIndex = 8;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(243, 174);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(100, 23);
            this.btnGuardarCambios.TabIndex = 9;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(243, 203);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(19, 203);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chbTieneEnvio
            // 
            this.chbTieneEnvio.AutoSize = true;
            this.chbTieneEnvio.BackColor = System.Drawing.Color.Transparent;
            this.chbTieneEnvio.Location = new System.Drawing.Point(254, 117);
            this.chbTieneEnvio.Name = "chbTieneEnvio";
            this.chbTieneEnvio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbTieneEnvio.Size = new System.Drawing.Size(89, 17);
            this.chbTieneEnvio.TabIndex = 12;
            this.chbTieneEnvio.Text = "?Tiene Envio";
            this.chbTieneEnvio.UseVisualStyleBackColor = false;
            this.chbTieneEnvio.CheckedChanged += new System.EventHandler(this.chbTieneEnvio_CheckedChanged);
            // 
            // btnOKVisibilidad
            // 
            this.btnOKVisibilidad.Location = new System.Drawing.Point(350, 27);
            this.btnOKVisibilidad.Name = "btnOKVisibilidad";
            this.btnOKVisibilidad.Size = new System.Drawing.Size(36, 23);
            this.btnOKVisibilidad.TabIndex = 13;
            this.btnOKVisibilidad.Text = "OK";
            this.btnOKVisibilidad.UseVisualStyleBackColor = true;
            this.btnOKVisibilidad.Click += new System.EventHandler(this.btnOKVisibilidad_Click);
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 238);
            this.Controls.Add(this.btnOKVisibilidad);
            this.Controls.Add(this.chbTieneEnvio);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.cmbNombreVisibilidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComisionXEnvioProducto);
            this.Controls.Add(this.txtComisionXProductoVendido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtComisionXTipoPublicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmModificar";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.frmModificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComisionXTipoPublicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComisionXProductoVendido;
        private System.Windows.Forms.TextBox txtComisionXEnvioProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNombreVisibilidad;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chbTieneEnvio;
        private System.Windows.Forms.Button btnOKVisibilidad;
    }
}