namespace GDD.Generar_Publicación
{
    partial class Form1
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
            this.btn_Rol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Rol
            // 
            this.btn_Rol.Location = new System.Drawing.Point(93, 30);
            this.btn_Rol.Name = "btn_Rol";
            this.btn_Rol.Size = new System.Drawing.Size(75, 23);
            this.btn_Rol.TabIndex = 0;
            this.btn_Rol.Text = "ABM Rol";
            this.btn_Rol.UseVisualStyleBackColor = true;
            this.btn_Rol.Click += new System.EventHandler(this.btn_Rol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Rol);
            this.Name = "Form1";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Rol;
    }
}