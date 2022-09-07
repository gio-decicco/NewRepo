namespace Carrera1._1
{
    partial class NuevaCarrera
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
            this.DtgDetalles = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuatriCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CboAsignaturas = new System.Windows.Forms.ComboBox();
            this.BtnAgregarDetalle = new System.Windows.Forms.Button();
            this.TbAño = new System.Windows.Forms.TextBox();
            this.TbCuatri = new System.Windows.Forms.TextBox();
            this.LblProximoId = new System.Windows.Forms.Label();
            this.LblAño = new System.Windows.Forms.Label();
            this.LblCuatrimestre = new System.Windows.Forms.Label();
            this.TbNombreC = new System.Windows.Forms.TextBox();
            this.TbTitulo = new System.Windows.Forms.TextBox();
            this.LblNomCarrera = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtgDetalles
            // 
            this.DtgDetalles.AllowUserToAddRows = false;
            this.DtgDetalles.AllowUserToDeleteRows = false;
            this.DtgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colAsignatura,
            this.AñoCursado,
            this.CuatriCursado,
            this.Asign});
            this.DtgDetalles.Location = new System.Drawing.Point(22, 144);
            this.DtgDetalles.Name = "DtgDetalles";
            this.DtgDetalles.ReadOnly = true;
            this.DtgDetalles.RowHeadersWidth = 51;
            this.DtgDetalles.Size = new System.Drawing.Size(342, 154);
            this.DtgDetalles.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // colAsignatura
            // 
            this.colAsignatura.HeaderText = "Asignatura";
            this.colAsignatura.MinimumWidth = 6;
            this.colAsignatura.Name = "colAsignatura";
            this.colAsignatura.ReadOnly = true;
            this.colAsignatura.Width = 170;
            // 
            // AñoCursado
            // 
            this.AñoCursado.HeaderText = "Año de Cursado";
            this.AñoCursado.MinimumWidth = 6;
            this.AñoCursado.Name = "AñoCursado";
            this.AñoCursado.ReadOnly = true;
            this.AñoCursado.Width = 50;
            // 
            // CuatriCursado
            // 
            this.CuatriCursado.HeaderText = "Cuatrimestre de Cursado";
            this.CuatriCursado.MinimumWidth = 6;
            this.CuatriCursado.Name = "CuatriCursado";
            this.CuatriCursado.ReadOnly = true;
            this.CuatriCursado.Width = 80;
            // 
            // Asign
            // 
            this.Asign.HeaderText = "AsignaturaObjeto";
            this.Asign.MinimumWidth = 6;
            this.Asign.Name = "Asign";
            this.Asign.ReadOnly = true;
            this.Asign.Visible = false;
            this.Asign.Width = 125;
            // 
            // CboAsignaturas
            // 
            this.CboAsignaturas.FormattingEnabled = true;
            this.CboAsignaturas.Location = new System.Drawing.Point(104, 22);
            this.CboAsignaturas.Name = "CboAsignaturas";
            this.CboAsignaturas.Size = new System.Drawing.Size(176, 21);
            this.CboAsignaturas.TabIndex = 1;
            // 
            // BtnAgregarDetalle
            // 
            this.BtnAgregarDetalle.Location = new System.Drawing.Point(268, 94);
            this.BtnAgregarDetalle.Name = "BtnAgregarDetalle";
            this.BtnAgregarDetalle.Size = new System.Drawing.Size(96, 21);
            this.BtnAgregarDetalle.TabIndex = 2;
            this.BtnAgregarDetalle.Text = "Agregar";
            this.BtnAgregarDetalle.UseVisualStyleBackColor = true;
            this.BtnAgregarDetalle.Click += new System.EventHandler(this.BtnAgregarDetalle_Click);
            // 
            // TbAño
            // 
            this.TbAño.Location = new System.Drawing.Point(104, 59);
            this.TbAño.Name = "TbAño";
            this.TbAño.Size = new System.Drawing.Size(141, 20);
            this.TbAño.TabIndex = 3;
            // 
            // TbCuatri
            // 
            this.TbCuatri.Location = new System.Drawing.Point(104, 95);
            this.TbCuatri.Name = "TbCuatri";
            this.TbCuatri.Size = new System.Drawing.Size(141, 20);
            this.TbCuatri.TabIndex = 4;
            // 
            // LblProximoId
            // 
            this.LblProximoId.AutoSize = true;
            this.LblProximoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProximoId.Location = new System.Drawing.Point(151, 25);
            this.LblProximoId.Name = "LblProximoId";
            this.LblProximoId.Size = new System.Drawing.Size(100, 20);
            this.LblProximoId.TabIndex = 5;
            this.LblProximoId.Text = "Id Carrera: ";
            // 
            // LblAño
            // 
            this.LblAño.AutoSize = true;
            this.LblAño.Location = new System.Drawing.Point(72, 63);
            this.LblAño.Name = "LblAño";
            this.LblAño.Size = new System.Drawing.Size(26, 13);
            this.LblAño.TabIndex = 6;
            this.LblAño.Text = "Año";
            // 
            // LblCuatrimestre
            // 
            this.LblCuatrimestre.AutoSize = true;
            this.LblCuatrimestre.Location = new System.Drawing.Point(33, 98);
            this.LblCuatrimestre.Name = "LblCuatrimestre";
            this.LblCuatrimestre.Size = new System.Drawing.Size(65, 13);
            this.LblCuatrimestre.TabIndex = 7;
            this.LblCuatrimestre.Text = "Cuatrimestre";
            // 
            // TbNombreC
            // 
            this.TbNombreC.Location = new System.Drawing.Point(152, 64);
            this.TbNombreC.Name = "TbNombreC";
            this.TbNombreC.Size = new System.Drawing.Size(184, 20);
            this.TbNombreC.TabIndex = 8;
            // 
            // TbTitulo
            // 
            this.TbTitulo.Location = new System.Drawing.Point(152, 110);
            this.TbTitulo.Name = "TbTitulo";
            this.TbTitulo.Size = new System.Drawing.Size(184, 20);
            this.TbTitulo.TabIndex = 9;
            // 
            // LblNomCarrera
            // 
            this.LblNomCarrera.AutoSize = true;
            this.LblNomCarrera.Location = new System.Drawing.Point(51, 67);
            this.LblNomCarrera.Name = "LblNomCarrera";
            this.LblNomCarrera.Size = new System.Drawing.Size(96, 13);
            this.LblNomCarrera.TabIndex = 10;
            this.LblNomCarrera.Text = "Nombre de Carrera";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(59, 113);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(87, 13);
            this.LblTitulo.TabIndex = 11;
            this.LblTitulo.Text = "Título de Carrera";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(233, 304);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(114, 23);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Asignatura";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblTitulo);
            this.groupBox1.Controls.Add(this.LblNomCarrera);
            this.groupBox1.Controls.Add(this.TbTitulo);
            this.groupBox1.Controls.Add(this.TbNombreC);
            this.groupBox1.Controls.Add(this.LblProximoId);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 171);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Carrera";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnGuardar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LblCuatrimestre);
            this.groupBox2.Controls.Add(this.BtnCancelar);
            this.groupBox2.Controls.Add(this.LblAño);
            this.groupBox2.Controls.Add(this.TbCuatri);
            this.groupBox2.Controls.Add(this.TbAño);
            this.groupBox2.Controls.Add(this.BtnAgregarDetalle);
            this.groupBox2.Controls.Add(this.CboAsignaturas);
            this.groupBox2.Controls.Add(this.DtgDetalles);
            this.groupBox2.Location = new System.Drawing.Point(14, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 337);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles de Carrera";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(36, 304);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(114, 23);
            this.BtnGuardar.TabIndex = 15;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // NuevaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevaCarrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaCarrera";
            this.Load += new System.EventHandler(this.NuevaCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgDetalles;
        private System.Windows.Forms.ComboBox CboAsignaturas;
        private System.Windows.Forms.Button BtnAgregarDetalle;
        private System.Windows.Forms.TextBox TbAño;
        private System.Windows.Forms.TextBox TbCuatri;
        private System.Windows.Forms.Label LblProximoId;
        private System.Windows.Forms.Label LblAño;
        private System.Windows.Forms.Label LblCuatrimestre;
        private System.Windows.Forms.TextBox TbNombreC;
        private System.Windows.Forms.TextBox TbTitulo;
        private System.Windows.Forms.Label LblNomCarrera;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuatriCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asign;
    }
}