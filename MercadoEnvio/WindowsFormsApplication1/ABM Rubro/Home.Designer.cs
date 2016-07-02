namespace GDD.ABM_Rubro
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbRubros = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rubros";
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(82, 51);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(298, 21);
            this.cmbProductos.TabIndex = 3;
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.cmbProductos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Productos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(106, 182);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbRubros
            // 
            this.cmbRubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubros.FormattingEnabled = true;
            this.cmbRubros.Location = new System.Drawing.Point(82, 118);
            this.cmbRubros.Name = "cmbRubros";
            this.cmbRubros.Size = new System.Drawing.Size(146, 21);
            this.cmbRubros.TabIndex = 6;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 248);
            this.Controls.Add(this.cmbRubros);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.label1);
            this.Name = "frmHome";
            this.Text = "ABM Rubro";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbRubros;
    }
}