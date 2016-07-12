namespace GDD.ComprarOfertar
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
            this.clbRubros = new System.Windows.Forms.CheckedListBox();
            this.lblTextoDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvPublicaciones = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnAccionar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblTextoPagina = new System.Windows.Forms.Label();
            this.lblPagina = new System.Windows.Forms.Label();
            this.txtAccion = new System.Windows.Forms.TextBox();
            this.lblTextoRubro = new System.Windows.Forms.Label();
            this.lblTextoAccion = new System.Windows.Forms.Label();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnNinguno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // clbRubros
            // 
            this.clbRubros.FormattingEnabled = true;
            this.clbRubros.Location = new System.Drawing.Point(175, 40);
            this.clbRubros.Name = "clbRubros";
            this.clbRubros.Size = new System.Drawing.Size(203, 276);
            this.clbRubros.Sorted = true;
            this.clbRubros.TabIndex = 0;
            // 
            // lblTextoDescripcion
            // 
            this.lblTextoDescripcion.AutoSize = true;
            this.lblTextoDescripcion.Location = new System.Drawing.Point(12, 15);
            this.lblTextoDescripcion.Name = "lblTextoDescripcion";
            this.lblTextoDescripcion.Size = new System.Drawing.Size(140, 17);
            this.lblTextoDescripcion.TabIndex = 1;
            this.lblTextoDescripcion.Text = "Filtrar por descipcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(175, 12);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(203, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // dgvPublicaciones
            // 
            this.dgvPublicaciones.AllowUserToAddRows = false;
            this.dgvPublicaciones.AllowUserToDeleteRows = false;
            this.dgvPublicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPublicaciones.Location = new System.Drawing.Point(384, 12);
            this.dgvPublicaciones.MultiSelect = false;
            this.dgvPublicaciones.Name = "dgvPublicaciones";
            this.dgvPublicaciones.ReadOnly = true;
            this.dgvPublicaciones.RowHeadersWidth = 20;
            this.dgvPublicaciones.RowTemplate.Height = 24;
            this.dgvPublicaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPublicaciones.Size = new System.Drawing.Size(923, 650);
            this.dgvPublicaciones.TabIndex = 4;
            this.dgvPublicaciones.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPublicaciones_MouseClick);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(12, 370);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(366, 35);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnAccionar
            // 
            this.btnAccionar.Enabled = false;
            this.btnAccionar.Location = new System.Drawing.Point(12, 627);
            this.btnAccionar.Name = "btnAccionar";
            this.btnAccionar.Size = new System.Drawing.Size(366, 35);
            this.btnAccionar.TabIndex = 6;
            this.btnAccionar.UseVisualStyleBackColor = true;
            this.btnAccionar.Click += new System.EventHandler(this.btnAccionar_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(545, 668);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(67, 51);
            this.btnInicio.TabIndex = 7;
            this.btnInicio.Text = "<<";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(1065, 668);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(67, 51);
            this.btnFin.TabIndex = 8;
            this.btnFin.Text = ">>";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(992, 668);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(67, 51);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(618, 668);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(67, 51);
            this.btnAnterior.TabIndex = 10;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblTextoPagina
            // 
            this.lblTextoPagina.AutoSize = true;
            this.lblTextoPagina.Location = new System.Drawing.Point(803, 685);
            this.lblTextoPagina.Name = "lblTextoPagina";
            this.lblTextoPagina.Size = new System.Drawing.Size(52, 17);
            this.lblTextoPagina.TabIndex = 11;
            this.lblTextoPagina.Text = "Página";
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Location = new System.Drawing.Point(861, 685);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(16, 17);
            this.lblPagina.TabIndex = 12;
            this.lblPagina.Text = "1";
            // 
            // txtAccion
            // 
            this.txtAccion.Enabled = false;
            this.txtAccion.Location = new System.Drawing.Point(175, 588);
            this.txtAccion.Name = "txtAccion";
            this.txtAccion.Size = new System.Drawing.Size(203, 22);
            this.txtAccion.TabIndex = 13;
            // 
            // lblTextoRubro
            // 
            this.lblTextoRubro.AutoSize = true;
            this.lblTextoRubro.Location = new System.Drawing.Point(12, 40);
            this.lblTextoRubro.Name = "lblTextoRubro";
            this.lblTextoRubro.Size = new System.Drawing.Size(107, 17);
            this.lblTextoRubro.TabIndex = 3;
            this.lblTextoRubro.Text = "Filtrar por rubro";
            // 
            // lblTextoAccion
            // 
            this.lblTextoAccion.AutoSize = true;
            this.lblTextoAccion.Enabled = false;
            this.lblTextoAccion.Location = new System.Drawing.Point(12, 591);
            this.lblTextoAccion.Name = "lblTextoAccion";
            this.lblTextoAccion.Size = new System.Drawing.Size(0, 17);
            this.lblTextoAccion.TabIndex = 14;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(302, 322);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(76, 35);
            this.btnTodos.TabIndex = 15;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnNinguno
            // 
            this.btnNinguno.Location = new System.Drawing.Point(175, 322);
            this.btnNinguno.Name = "btnNinguno";
            this.btnNinguno.Size = new System.Drawing.Size(75, 35);
            this.btnNinguno.TabIndex = 16;
            this.btnNinguno.Text = "Ninguno";
            this.btnNinguno.UseVisualStyleBackColor = true;
            this.btnNinguno.Click += new System.EventHandler(this.btnNinguno_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 731);
            this.Controls.Add(this.btnNinguno);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.lblTextoAccion);
            this.Controls.Add(this.txtAccion);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.lblTextoPagina);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnAccionar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dgvPublicaciones);
            this.Controls.Add(this.lblTextoRubro);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblTextoDescripcion);
            this.Controls.Add(this.clbRubros);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHome";
            this.Text = "Comprar - Ofertar";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbRubros;
        private System.Windows.Forms.Label lblTextoDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DataGridView dgvPublicaciones;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnAccionar;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblTextoPagina;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.TextBox txtAccion;
        private System.Windows.Forms.Label lblTextoRubro;
        private System.Windows.Forms.Label lblTextoAccion;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnNinguno;
    }
}