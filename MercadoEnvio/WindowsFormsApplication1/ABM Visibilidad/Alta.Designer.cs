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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreVisibilidad = new System.Windows.Forms.TextBox();
            this.txtComisionTipoPublicacion = new System.Windows.Forms.TextBox();
            this.txtComsionProductoVendido = new System.Windows.Forms.TextBox();
            this.txtComisionEnvioProducto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de visibilidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comision por tipo de publicacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comision por producto vendido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comisión por envío del producto";
            // 
            // txtNombreVisibilidad
            // 
            this.txtNombreVisibilidad.Location = new System.Drawing.Point(236, 30);
            this.txtNombreVisibilidad.Name = "txtNombreVisibilidad";
            this.txtNombreVisibilidad.Size = new System.Drawing.Size(173, 20);
            this.txtNombreVisibilidad.TabIndex = 4;
            // 
            // txtComisionTipoPublicacion
            // 
            this.txtComisionTipoPublicacion.Location = new System.Drawing.Point(236, 62);
            this.txtComisionTipoPublicacion.Name = "txtComisionTipoPublicacion";
            this.txtComisionTipoPublicacion.Size = new System.Drawing.Size(173, 20);
            this.txtComisionTipoPublicacion.TabIndex = 5;
            // 
            // txtComsionProductoVendido
            // 
            this.txtComsionProductoVendido.Location = new System.Drawing.Point(236, 94);
            this.txtComsionProductoVendido.Name = "txtComsionProductoVendido";
            this.txtComsionProductoVendido.Size = new System.Drawing.Size(173, 20);
            this.txtComsionProductoVendido.TabIndex = 6;
            // 
            // txtComisionEnvioProducto
            // 
            this.txtComisionEnvioProducto.Location = new System.Drawing.Point(236, 126);
            this.txtComisionEnvioProducto.Name = "txtComisionEnvioProducto";
            this.txtComisionEnvioProducto.Size = new System.Drawing.Size(173, 20);
            this.txtComisionEnvioProducto.TabIndex = 7;
            // 
            // frmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 184);
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
    }
}