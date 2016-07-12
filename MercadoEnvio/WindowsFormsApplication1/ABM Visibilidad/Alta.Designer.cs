namespace GDD.ABM_Visibilidad
{
    partial class frmAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreVisibilidad = new System.Windows.Forms.TextBox();
            this.txtComisionTipoPublicacion = new System.Windows.Forms.TextBox();
            this.txtComsionProductoVendido = new System.Windows.Forms.TextBox();
            this.txtComisionEnvioProducto = new System.Windows.Forms.TextBox();
            this.btnGuardarNuevaVisibilidad = new System.Windows.Forms.Button();
            this.chbTieneEnvio = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de visibilidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comision por tipo de publicacion ($)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comision por producto vendido (%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comisión por envío del producto ($)";
            // 
            // txtNombreVisibilidad
            // 
            this.txtNombreVisibilidad.Location = new System.Drawing.Point(243, 19);
            this.txtNombreVisibilidad.Name = "txtNombreVisibilidad";
            this.txtNombreVisibilidad.Size = new System.Drawing.Size(173, 20);
            this.txtNombreVisibilidad.TabIndex = 4;
            this.txtNombreVisibilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreVisibilidad_KeyPress);
            // 
            // txtComisionTipoPublicacion
            // 
            this.txtComisionTipoPublicacion.Location = new System.Drawing.Point(243, 51);
            this.txtComisionTipoPublicacion.Name = "txtComisionTipoPublicacion";
            this.txtComisionTipoPublicacion.Size = new System.Drawing.Size(173, 20);
            this.txtComisionTipoPublicacion.TabIndex = 5;
            this.txtComisionTipoPublicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComisionTipoPublicacion_KeyPress);
            // 
            // txtComsionProductoVendido
            // 
            this.txtComsionProductoVendido.Location = new System.Drawing.Point(243, 83);
            this.txtComsionProductoVendido.Name = "txtComsionProductoVendido";
            this.txtComsionProductoVendido.Size = new System.Drawing.Size(173, 20);
            this.txtComsionProductoVendido.TabIndex = 6;
            this.txtComsionProductoVendido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComsionProductoVendido_KeyPress);
            // 
            // txtComisionEnvioProducto
            // 
            this.txtComisionEnvioProducto.Enabled = false;
            this.txtComisionEnvioProducto.Location = new System.Drawing.Point(243, 134);
            this.txtComisionEnvioProducto.Name = "txtComisionEnvioProducto";
            this.txtComisionEnvioProducto.Size = new System.Drawing.Size(173, 20);
            this.txtComisionEnvioProducto.TabIndex = 7;
            this.txtComisionEnvioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComisionEnvioProducto_KeyPress);
            // 
            // btnGuardarNuevaVisibilidad
            // 
            this.btnGuardarNuevaVisibilidad.Location = new System.Drawing.Point(264, 179);
            this.btnGuardarNuevaVisibilidad.Name = "btnGuardarNuevaVisibilidad";
            this.btnGuardarNuevaVisibilidad.Size = new System.Drawing.Size(152, 23);
            this.btnGuardarNuevaVisibilidad.TabIndex = 8;
            this.btnGuardarNuevaVisibilidad.Text = "Guardar nueva visibilidad";
            this.btnGuardarNuevaVisibilidad.UseVisualStyleBackColor = true;
            this.btnGuardarNuevaVisibilidad.Click += new System.EventHandler(this.btnGuardarNuevaVisibilidad_Click);
            // 
            // chbTieneEnvio
            // 
            this.chbTieneEnvio.AutoSize = true;
            this.chbTieneEnvio.Location = new System.Drawing.Point(328, 111);
            this.chbTieneEnvio.Name = "chbTieneEnvio";
            this.chbTieneEnvio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbTieneEnvio.Size = new System.Drawing.Size(88, 17);
            this.chbTieneEnvio.TabIndex = 9;
            this.chbTieneEnvio.Text = "?Tiene envio";
            this.chbTieneEnvio.UseVisualStyleBackColor = true;
            this.chbTieneEnvio.CheckedChanged += new System.EventHandler(this.chbTieneEnvio_CheckedChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(264, 208);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(152, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(441, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(146, 131);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // frmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 236);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.chbTieneEnvio);
            this.Controls.Add(this.btnGuardarNuevaVisibilidad);
            this.Controls.Add(this.txtComisionEnvioProducto);
            this.Controls.Add(this.txtComsionProductoVendido);
            this.Controls.Add(this.txtComisionTipoPublicacion);
            this.Controls.Add(this.txtNombreVisibilidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAlta";
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.frmAlta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreVisibilidad;
        private System.Windows.Forms.TextBox txtComisionTipoPublicacion;
        private System.Windows.Forms.TextBox txtComsionProductoVendido;
        private System.Windows.Forms.TextBox txtComisionEnvioProducto;
        private System.Windows.Forms.Button btnGuardarNuevaVisibilidad;
        private System.Windows.Forms.CheckBox chbTieneEnvio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}