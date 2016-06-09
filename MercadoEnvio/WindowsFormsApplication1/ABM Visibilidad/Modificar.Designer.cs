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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComisionXTipoPublicacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComisionXProductoVendido = new System.Windows.Forms.TextBox();
            this.txtComisionXEnvioProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(243, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(129, 17);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de visibilidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comisión por tipo de publicación";
            // 
            // txtComisionXTipoPublicacion
            // 
            this.txtComisionXTipoPublicacion.Location = new System.Drawing.Point(243, 56);
            this.txtComisionXTipoPublicacion.Name = "txtComisionXTipoPublicacion";
            this.txtComisionXTipoPublicacion.Size = new System.Drawing.Size(100, 20);
            this.txtComisionXTipoPublicacion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comisión por producto vendido";
            // 
            // txtComisionXProductoVendido
            // 
            this.txtComisionXProductoVendido.Location = new System.Drawing.Point(243, 91);
            this.txtComisionXProductoVendido.Name = "txtComisionXProductoVendido";
            this.txtComisionXProductoVendido.Size = new System.Drawing.Size(100, 20);
            this.txtComisionXProductoVendido.TabIndex = 5;
            // 
            // txtComisionXEnvioProducto
            // 
            this.txtComisionXEnvioProducto.Location = new System.Drawing.Point(243, 124);
            this.txtComisionXEnvioProducto.Name = "txtComisionXEnvioProducto";
            this.txtComisionXEnvioProducto.Size = new System.Drawing.Size(100, 20);
            this.txtComisionXEnvioProducto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Comisión por envío del producto";
            // 
            // frmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 238);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComisionXEnvioProducto);
            this.Controls.Add(this.txtComisionXProductoVendido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtComisionXTipoPublicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "frmModificar";
            this.Text = "Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComisionXTipoPublicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComisionXProductoVendido;
        private System.Windows.Forms.TextBox txtComisionXEnvioProducto;
        private System.Windows.Forms.Label label4;
    }
}