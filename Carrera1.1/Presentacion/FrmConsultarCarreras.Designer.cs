namespace Carrera1._1
{
    partial class FrmConsultarCarreras
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbtDeshabilitadas = new System.Windows.Forms.RadioButton();
            this.RbtHabilitadas = new System.Windows.Forms.RadioButton();
            this.LstCarreras = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtMaterias = new System.Windows.Forms.TextBox();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNomCarrera = new System.Windows.Forms.Label();
            this.BtnDeshabilitar = new System.Windows.Forms.Button();
            this.BtnListo = new System.Windows.Forms.Button();
            this.BtnHabilitar = new System.Windows.Forms.Button();
            this.DtgDetalles = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAñoCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbtDeshabilitadas);
            this.groupBox1.Controls.Add(this.RbtHabilitadas);
            this.groupBox1.Controls.Add(this.LstCarreras);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carreras";
            // 
            // RbtDeshabilitadas
            // 
            this.RbtDeshabilitadas.AutoSize = true;
            this.RbtDeshabilitadas.Location = new System.Drawing.Point(240, 19);
            this.RbtDeshabilitadas.Name = "RbtDeshabilitadas";
            this.RbtDeshabilitadas.Size = new System.Drawing.Size(94, 17);
            this.RbtDeshabilitadas.TabIndex = 2;
            this.RbtDeshabilitadas.TabStop = true;
            this.RbtDeshabilitadas.Text = "Deshabilitadas";
            this.RbtDeshabilitadas.UseVisualStyleBackColor = true;
            this.RbtDeshabilitadas.CheckedChanged += new System.EventHandler(this.RbtDeshabilitadas_CheckedChanged);
            // 
            // RbtHabilitadas
            // 
            this.RbtHabilitadas.AutoSize = true;
            this.RbtHabilitadas.Location = new System.Drawing.Point(72, 19);
            this.RbtHabilitadas.Name = "RbtHabilitadas";
            this.RbtHabilitadas.Size = new System.Drawing.Size(77, 17);
            this.RbtHabilitadas.TabIndex = 1;
            this.RbtHabilitadas.TabStop = true;
            this.RbtHabilitadas.Text = "Habilitadas";
            this.RbtHabilitadas.UseVisualStyleBackColor = true;
            // 
            // LstCarreras
            // 
            this.LstCarreras.FormattingEnabled = true;
            this.LstCarreras.Location = new System.Drawing.Point(7, 45);
            this.LstCarreras.Name = "LstCarreras";
            this.LstCarreras.Size = new System.Drawing.Size(368, 199);
            this.LstCarreras.TabIndex = 0;
            this.LstCarreras.SelectedIndexChanged += new System.EventHandler(this.LstCarreras_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtMaterias);
            this.groupBox2.Controls.Add(this.TxtEstado);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtTitulo);
            this.groupBox2.Controls.Add(this.TxtNombre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LblNomCarrera);
            this.groupBox2.Location = new System.Drawing.Point(12, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Carrera";
            // 
            // TxtMaterias
            // 
            this.TxtMaterias.Location = new System.Drawing.Point(151, 148);
            this.TxtMaterias.Name = "TxtMaterias";
            this.TxtMaterias.Size = new System.Drawing.Size(52, 20);
            this.TxtMaterias.TabIndex = 7;
            // 
            // TxtEstado
            // 
            this.TxtEstado.Location = new System.Drawing.Point(151, 204);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(187, 20);
            this.TxtEstado.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estado";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(151, 92);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(187, 20);
            this.TxtTitulo.TabIndex = 4;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(151, 36);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(187, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de Materias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título";
            // 
            // LblNomCarrera
            // 
            this.LblNomCarrera.AutoSize = true;
            this.LblNomCarrera.Location = new System.Drawing.Point(101, 39);
            this.LblNomCarrera.Name = "LblNomCarrera";
            this.LblNomCarrera.Size = new System.Drawing.Size(44, 13);
            this.LblNomCarrera.TabIndex = 0;
            this.LblNomCarrera.Text = "Nombre";
            // 
            // BtnDeshabilitar
            // 
            this.BtnDeshabilitar.Location = new System.Drawing.Point(356, 537);
            this.BtnDeshabilitar.Name = "BtnDeshabilitar";
            this.BtnDeshabilitar.Size = new System.Drawing.Size(91, 31);
            this.BtnDeshabilitar.TabIndex = 3;
            this.BtnDeshabilitar.Text = "Deshabilitar";
            this.BtnDeshabilitar.UseVisualStyleBackColor = true;
            this.BtnDeshabilitar.Click += new System.EventHandler(this.BtnDeshabilitar_Click);
            // 
            // BtnListo
            // 
            this.BtnListo.Location = new System.Drawing.Point(698, 537);
            this.BtnListo.Name = "BtnListo";
            this.BtnListo.Size = new System.Drawing.Size(91, 31);
            this.BtnListo.TabIndex = 4;
            this.BtnListo.Text = "Listo";
            this.BtnListo.UseVisualStyleBackColor = true;
            this.BtnListo.Click += new System.EventHandler(this.BtnListo_Click);
            // 
            // BtnHabilitar
            // 
            this.BtnHabilitar.Location = new System.Drawing.Point(12, 537);
            this.BtnHabilitar.Name = "BtnHabilitar";
            this.BtnHabilitar.Size = new System.Drawing.Size(93, 31);
            this.BtnHabilitar.TabIndex = 5;
            this.BtnHabilitar.Text = "Habilitar";
            this.BtnHabilitar.UseVisualStyleBackColor = true;
            this.BtnHabilitar.Click += new System.EventHandler(this.BtnHabilitar_Click);
            // 
            // DtgDetalles
            // 
            this.DtgDetalles.AllowUserToAddRows = false;
            this.DtgDetalles.AllowUserToDeleteRows = false;
            this.DtgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColAsignatura,
            this.ColAñoCursado,
            this.ColCuatrimestre});
            this.DtgDetalles.Location = new System.Drawing.Point(398, 12);
            this.DtgDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.DtgDetalles.Name = "DtgDetalles";
            this.DtgDetalles.ReadOnly = true;
            this.DtgDetalles.RowHeadersWidth = 51;
            this.DtgDetalles.RowTemplate.Height = 24;
            this.DtgDetalles.Size = new System.Drawing.Size(392, 519);
            this.DtgDetalles.TabIndex = 7;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColAsignatura
            // 
            this.ColAsignatura.HeaderText = "Asignatura";
            this.ColAsignatura.Name = "ColAsignatura";
            this.ColAsignatura.ReadOnly = true;
            this.ColAsignatura.Width = 140;
            // 
            // ColAñoCursado
            // 
            this.ColAñoCursado.HeaderText = "Año de Cursado";
            this.ColAñoCursado.Name = "ColAñoCursado";
            this.ColAñoCursado.ReadOnly = true;
            // 
            // ColCuatrimestre
            // 
            this.ColCuatrimestre.HeaderText = "Cuatrimestre";
            this.ColCuatrimestre.Name = "ColCuatrimestre";
            this.ColCuatrimestre.ReadOnly = true;
            // 
            // FrmConsultarCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.DtgDetalles);
            this.Controls.Add(this.BtnHabilitar);
            this.Controls.Add(this.BtnListo);
            this.Controls.Add(this.BtnDeshabilitar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultarCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Carreras";
            this.Load += new System.EventHandler(this.FrmConsultarCarreras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDeshabilitar;
        private System.Windows.Forms.Button BtnListo;
        private System.Windows.Forms.ListBox LstCarreras;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNomCarrera;
        private System.Windows.Forms.Button BtnHabilitar;
        private System.Windows.Forms.RadioButton RbtDeshabilitadas;
        private System.Windows.Forms.RadioButton RbtHabilitadas;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMaterias;
        private System.Windows.Forms.DataGridView DtgDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAñoCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuatrimestre;
    }
}