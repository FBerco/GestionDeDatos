namespace GDD.Generar_Publicación
{
    partial class FiltrarPublicacion
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
            this.dgvPublicacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "en este form filtro publicacion, como en datosEmpresa en ABMUsuario, selecciono l" +
    "a publicacion y hay un boton que me lleva al form ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ALTA y se cargan los datos de esta publicacion que seleccione";
            // 
            // dgvPublicacion
            // 
            this.dgvPublicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublicacion.Location = new System.Drawing.Point(118, 164);
            this.dgvPublicacion.Name = "dgvPublicacion";
            this.dgvPublicacion.Size = new System.Drawing.Size(152, 136);
            this.dgvPublicacion.TabIndex = 2;
            // 
            // FiltrarPublicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 480);
            this.Controls.Add(this.dgvPublicacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FiltrarPublicacion";
            this.Text = "FiltrarPublicacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPublicacion;
    }
}