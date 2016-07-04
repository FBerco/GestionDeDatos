namespace GDD.ABM_Visibilidad
{
    partial class frmBaja
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
            this.cmbNombreVisibilidad = new System.Windows.Forms.ComboBox();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de visibilidad";
            // 
            // cmbNombreVisibilidad
            // 
            this.cmbNombreVisibilidad.FormattingEnabled = true;
            this.cmbNombreVisibilidad.Location = new System.Drawing.Point(127, 37);
            this.cmbNombreVisibilidad.Name = "cmbNombreVisibilidad";
            this.cmbNombreVisibilidad.Size = new System.Drawing.Size(145, 21);
            this.cmbNombreVisibilidad.TabIndex = 2;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(127, 153);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 3;
            this.btnBaja.Text = "Dar de baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 152);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 188);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.cmbNombreVisibilidad);
            this.Controls.Add(this.label1);
            this.Name = "frmBaja";
            this.Text = "ABM Visibilidad - Baja";
            this.Load += new System.EventHandler(this.frmBaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNombreVisibilidad;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnBack;
    }
}