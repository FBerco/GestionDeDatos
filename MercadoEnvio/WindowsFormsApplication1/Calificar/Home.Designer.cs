namespace GDD.Calificar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.cmbEstrellas = new System.Windows.Forms.ComboBox();
            this.dgvComprasACalificar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUltimas5 = new System.Windows.Forms.DataGridView();
            this.txtComprasRealizadas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt1EstrellaCompra = new System.Windows.Forms.TextBox();
            this.txt2EstrellasCompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt3EstrellasCompra = new System.Windows.Forms.TextBox();
            this.txt4EstrellasCompra = new System.Windows.Forms.TextBox();
            this.txt5EstrellasCompra = new System.Windows.Forms.TextBox();
            this.txtTotalEstrellasOtrogadasCompra = new System.Windows.Forms.TextBox();
            this.txtTotalEstrellasOtrogadasSubasta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt5EstrellasSubasta = new System.Windows.Forms.TextBox();
            this.txt4EstrellasSubasta = new System.Windows.Forms.TextBox();
            this.txt3EstrellasSubasta = new System.Windows.Forms.TextBox();
            this.txt2EstrellasSubasta = new System.Windows.Forms.TextBox();
            this.txt1EstrellaSubasta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSubastasRealizadas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotalDeEstrellas = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasACalificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimas5)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estrellas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Detalle";
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(148, 281);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(75, 23);
            this.btnCalificar.TabIndex = 4;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(213, 241);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(100, 20);
            this.txtDetalle.TabIndex = 6;
            // 
            // cmbEstrellas
            // 
            this.cmbEstrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstrellas.FormattingEnabled = true;
            this.cmbEstrellas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbEstrellas.Location = new System.Drawing.Point(213, 172);
            this.cmbEstrellas.Name = "cmbEstrellas";
            this.cmbEstrellas.Size = new System.Drawing.Size(121, 21);
            this.cmbEstrellas.TabIndex = 8;
            // 
            // dgvComprasACalificar
            // 
            this.dgvComprasACalificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprasACalificar.Location = new System.Drawing.Point(14, 38);
            this.dgvComprasACalificar.Name = "dgvComprasACalificar";
            this.dgvComprasACalificar.ReadOnly = true;
            this.dgvComprasACalificar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComprasACalificar.Size = new System.Drawing.Size(350, 119);
            this.dgvComprasACalificar.TabIndex = 9;
            this.dgvComprasACalificar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvComprasACalificar_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "COMPRAS A CALIFICAR";
            // 
            // dgvUltimas5
            // 
            this.dgvUltimas5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUltimas5.Location = new System.Drawing.Point(384, 38);
            this.dgvUltimas5.Name = "dgvUltimas5";
            this.dgvUltimas5.ReadOnly = true;
            this.dgvUltimas5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUltimas5.Size = new System.Drawing.Size(350, 166);
            this.dgvUltimas5.TabIndex = 11;
            // 
            // txtComprasRealizadas
            // 
            this.txtComprasRealizadas.Location = new System.Drawing.Point(523, 241);
            this.txtComprasRealizadas.Name = "txtComprasRealizadas";
            this.txtComprasRealizadas.ReadOnly = true;
            this.txtComprasRealizadas.Size = new System.Drawing.Size(52, 20);
            this.txtComprasRealizadas.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(828, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Compras";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(757, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "1 Estrella";
            // 
            // txt1EstrellaCompra
            // 
            this.txt1EstrellaCompra.Location = new System.Drawing.Point(826, 79);
            this.txt1EstrellaCompra.Name = "txt1EstrellaCompra";
            this.txt1EstrellaCompra.ReadOnly = true;
            this.txt1EstrellaCompra.Size = new System.Drawing.Size(52, 20);
            this.txt1EstrellaCompra.TabIndex = 15;
            // 
            // txt2EstrellasCompra
            // 
            this.txt2EstrellasCompra.Location = new System.Drawing.Point(826, 114);
            this.txt2EstrellasCompra.Name = "txt2EstrellasCompra";
            this.txt2EstrellasCompra.ReadOnly = true;
            this.txt2EstrellasCompra.Size = new System.Drawing.Size(52, 20);
            this.txt2EstrellasCompra.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(757, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "2 Estrellas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(757, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "3 Estrellas";
            // 
            // txt3EstrellasCompra
            // 
            this.txt3EstrellasCompra.Location = new System.Drawing.Point(826, 150);
            this.txt3EstrellasCompra.Name = "txt3EstrellasCompra";
            this.txt3EstrellasCompra.ReadOnly = true;
            this.txt3EstrellasCompra.Size = new System.Drawing.Size(52, 20);
            this.txt3EstrellasCompra.TabIndex = 19;
            // 
            // txt4EstrellasCompra
            // 
            this.txt4EstrellasCompra.Location = new System.Drawing.Point(826, 184);
            this.txt4EstrellasCompra.Name = "txt4EstrellasCompra";
            this.txt4EstrellasCompra.ReadOnly = true;
            this.txt4EstrellasCompra.Size = new System.Drawing.Size(52, 20);
            this.txt4EstrellasCompra.TabIndex = 20;
            // 
            // txt5EstrellasCompra
            // 
            this.txt5EstrellasCompra.Location = new System.Drawing.Point(826, 218);
            this.txt5EstrellasCompra.Name = "txt5EstrellasCompra";
            this.txt5EstrellasCompra.ReadOnly = true;
            this.txt5EstrellasCompra.Size = new System.Drawing.Size(52, 20);
            this.txt5EstrellasCompra.TabIndex = 21;
            // 
            // txtTotalEstrellasOtrogadasCompra
            // 
            this.txtTotalEstrellasOtrogadasCompra.Location = new System.Drawing.Point(682, 241);
            this.txtTotalEstrellasOtrogadasCompra.Name = "txtTotalEstrellasOtrogadasCompra";
            this.txtTotalEstrellasOtrogadasCompra.ReadOnly = true;
            this.txtTotalEstrellasOtrogadasCompra.Size = new System.Drawing.Size(52, 20);
            this.txtTotalEstrellasOtrogadasCompra.TabIndex = 22;
            // 
            // txtTotalEstrellasOtrogadasSubasta
            // 
            this.txtTotalEstrellasOtrogadasSubasta.Location = new System.Drawing.Point(682, 281);
            this.txtTotalEstrellasOtrogadasSubasta.Name = "txtTotalEstrellasOtrogadasSubasta";
            this.txtTotalEstrellasOtrogadasSubasta.ReadOnly = true;
            this.txtTotalEstrellasOtrogadasSubasta.Size = new System.Drawing.Size(52, 20);
            this.txtTotalEstrellasOtrogadasSubasta.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(757, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "4 Estrellas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(757, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "5 Estrellas";
            // 
            // txt5EstrellasSubasta
            // 
            this.txt5EstrellasSubasta.Location = new System.Drawing.Point(884, 218);
            this.txt5EstrellasSubasta.Name = "txt5EstrellasSubasta";
            this.txt5EstrellasSubasta.ReadOnly = true;
            this.txt5EstrellasSubasta.Size = new System.Drawing.Size(52, 20);
            this.txt5EstrellasSubasta.TabIndex = 30;
            // 
            // txt4EstrellasSubasta
            // 
            this.txt4EstrellasSubasta.Location = new System.Drawing.Point(884, 184);
            this.txt4EstrellasSubasta.Name = "txt4EstrellasSubasta";
            this.txt4EstrellasSubasta.ReadOnly = true;
            this.txt4EstrellasSubasta.Size = new System.Drawing.Size(52, 20);
            this.txt4EstrellasSubasta.TabIndex = 29;
            // 
            // txt3EstrellasSubasta
            // 
            this.txt3EstrellasSubasta.Location = new System.Drawing.Point(884, 150);
            this.txt3EstrellasSubasta.Name = "txt3EstrellasSubasta";
            this.txt3EstrellasSubasta.ReadOnly = true;
            this.txt3EstrellasSubasta.Size = new System.Drawing.Size(52, 20);
            this.txt3EstrellasSubasta.TabIndex = 28;
            // 
            // txt2EstrellasSubasta
            // 
            this.txt2EstrellasSubasta.Location = new System.Drawing.Point(884, 114);
            this.txt2EstrellasSubasta.Name = "txt2EstrellasSubasta";
            this.txt2EstrellasSubasta.ReadOnly = true;
            this.txt2EstrellasSubasta.Size = new System.Drawing.Size(52, 20);
            this.txt2EstrellasSubasta.TabIndex = 27;
            // 
            // txt1EstrellaSubasta
            // 
            this.txt1EstrellaSubasta.Location = new System.Drawing.Point(884, 79);
            this.txt1EstrellaSubasta.Name = "txt1EstrellaSubasta";
            this.txt1EstrellaSubasta.ReadOnly = true;
            this.txt1EstrellaSubasta.Size = new System.Drawing.Size(52, 20);
            this.txt1EstrellaSubasta.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(885, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Subastas";
            // 
            // txtSubastasRealizadas
            // 
            this.txtSubastasRealizadas.Location = new System.Drawing.Point(523, 281);
            this.txtSubastasRealizadas.Name = "txtSubastasRealizadas";
            this.txtSubastasRealizadas.ReadOnly = true;
            this.txtSubastasRealizadas.Size = new System.Drawing.Size(52, 20);
            this.txtSubastasRealizadas.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(384, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "CANTIDAD DE TRANSACCIONES";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(757, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "TRANSACCIONES CALIFICADAS CON";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(600, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(193, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "RESUMEN DE CALIFICACIONES";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(384, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Subastas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(384, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Compras";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(594, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "ESTRELLAS OTORGADAS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(594, 244);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Compras";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(594, 284);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Subastas";
            // 
            // txtTotalDeEstrellas
            // 
            this.txtTotalDeEstrellas.Location = new System.Drawing.Point(884, 281);
            this.txtTotalDeEstrellas.Name = "txtTotalDeEstrellas";
            this.txtTotalDeEstrellas.ReadOnly = true;
            this.txtTotalDeEstrellas.Size = new System.Drawing.Size(52, 20);
            this.txtTotalDeEstrellas.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(750, 284);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "TOTAL DE ESTRELLAS ";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 316);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtTotalDeEstrellas);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSubastasRealizadas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt5EstrellasSubasta);
            this.Controls.Add(this.txt4EstrellasSubasta);
            this.Controls.Add(this.txt3EstrellasSubasta);
            this.Controls.Add(this.txt2EstrellasSubasta);
            this.Controls.Add(this.txt1EstrellaSubasta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalEstrellasOtrogadasSubasta);
            this.Controls.Add(this.txtTotalEstrellasOtrogadasCompra);
            this.Controls.Add(this.txt5EstrellasCompra);
            this.Controls.Add(this.txt4EstrellasCompra);
            this.Controls.Add(this.txt3EstrellasCompra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt2EstrellasCompra);
            this.Controls.Add(this.txt1EstrellaCompra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComprasRealizadas);
            this.Controls.Add(this.dgvUltimas5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvComprasACalificar);
            this.Controls.Add(this.cmbEstrellas);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.btnCalificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmHome";
            this.Text = "Calificar";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasACalificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUltimas5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.ComboBox cmbEstrellas;
        private System.Windows.Forms.DataGridView dgvComprasACalificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUltimas5;
        private System.Windows.Forms.TextBox txtComprasRealizadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt1EstrellaCompra;
        private System.Windows.Forms.TextBox txt2EstrellasCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt3EstrellasCompra;
        private System.Windows.Forms.TextBox txt4EstrellasCompra;
        private System.Windows.Forms.TextBox txt5EstrellasCompra;
        private System.Windows.Forms.TextBox txtTotalEstrellasOtrogadasCompra;
        private System.Windows.Forms.TextBox txtTotalEstrellasOtrogadasSubasta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt5EstrellasSubasta;
        private System.Windows.Forms.TextBox txt4EstrellasSubasta;
        private System.Windows.Forms.TextBox txt3EstrellasSubasta;
        private System.Windows.Forms.TextBox txt2EstrellasSubasta;
        private System.Windows.Forms.TextBox txt1EstrellaSubasta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSubastasRealizadas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTotalDeEstrellas;
        private System.Windows.Forms.Label label19;
    }
}