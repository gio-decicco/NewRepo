namespace Carrera1._1.Presentacion
{
    partial class FrmModificarDetalles
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
            this.Confirmar = new System.Windows.Forms.Button();
            this.BtnListo = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.GroupCarrera = new System.Windows.Forms.GroupBox();
            this.LstCarreras = new System.Windows.Forms.ListBox();
            this.Detalles = new System.Windows.Forms.GroupBox();
            this.BtnAgregarDetalle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCuatri = new System.Windows.Forms.TextBox();
            this.TxtAño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CboAsignaturas = new System.Windows.Forms.ComboBox();
            this.DtgDetalles = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAsignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuatri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GroupCarrera.SuspendLayout();
            this.Detalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirmar
            // 
            this.Confirmar.Location = new System.Drawing.Point(15, 740);
            this.Confirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Confirmar.Name = "Confirmar";
            this.Confirmar.Size = new System.Drawing.Size(107, 34);
            this.Confirmar.TabIndex = 10;
            this.Confirmar.Text = "Confirmar";
            this.Confirmar.UseVisualStyleBackColor = true;
            this.Confirmar.Click += new System.EventHandler(this.Confirmar_Click);
            // 
            // BtnListo
            // 
            this.BtnListo.Location = new System.Drawing.Point(741, 740);
            this.BtnListo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnListo.Name = "BtnListo";
            this.BtnListo.Size = new System.Drawing.Size(107, 34);
            this.BtnListo.TabIndex = 11;
            this.BtnListo.Text = "Listo";
            this.BtnListo.UseVisualStyleBackColor = true;
            this.BtnListo.Click += new System.EventHandler(this.BtnListo_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(533, 41);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(257, 22);
            this.TxtNombre.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Título";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(533, 89);
            this.TxtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(257, 22);
            this.TxtTitulo.TabIndex = 14;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(648, 346);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(105, 34);
            this.BtnEditar.TabIndex = 16;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // GroupCarrera
            // 
            this.GroupCarrera.Controls.Add(this.LstCarreras);
            this.GroupCarrera.Controls.Add(this.BtnEditar);
            this.GroupCarrera.Controls.Add(this.label6);
            this.GroupCarrera.Controls.Add(this.TxtTitulo);
            this.GroupCarrera.Controls.Add(this.TxtNombre);
            this.GroupCarrera.Controls.Add(this.label5);
            this.GroupCarrera.Location = new System.Drawing.Point(12, 15);
            this.GroupCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.GroupCarrera.Name = "GroupCarrera";
            this.GroupCarrera.Padding = new System.Windows.Forms.Padding(4);
            this.GroupCarrera.Size = new System.Drawing.Size(835, 399);
            this.GroupCarrera.TabIndex = 17;
            this.GroupCarrera.TabStop = false;
            this.GroupCarrera.Text = "Carrera";
            // 
            // LstCarreras
            // 
            this.LstCarreras.FormattingEnabled = true;
            this.LstCarreras.ItemHeight = 16;
            this.LstCarreras.Location = new System.Drawing.Point(8, 23);
            this.LstCarreras.Margin = new System.Windows.Forms.Padding(4);
            this.LstCarreras.Name = "LstCarreras";
            this.LstCarreras.Size = new System.Drawing.Size(415, 356);
            this.LstCarreras.TabIndex = 17;
            this.LstCarreras.SelectedIndexChanged += new System.EventHandler(this.LstCarreras_SelectedIndexChanged);
            // 
            // Detalles
            // 
            this.Detalles.Controls.Add(this.BtnAgregarDetalle);
            this.Detalles.Controls.Add(this.label4);
            this.Detalles.Controls.Add(this.TxtCuatri);
            this.Detalles.Controls.Add(this.TxtAño);
            this.Detalles.Controls.Add(this.label3);
            this.Detalles.Controls.Add(this.label2);
            this.Detalles.Controls.Add(this.CboAsignaturas);
            this.Detalles.Controls.Add(this.DtgDetalles);
            this.Detalles.Location = new System.Drawing.Point(15, 421);
            this.Detalles.Margin = new System.Windows.Forms.Padding(4);
            this.Detalles.Name = "Detalles";
            this.Detalles.Padding = new System.Windows.Forms.Padding(4);
            this.Detalles.Size = new System.Drawing.Size(832, 313);
            this.Detalles.TabIndex = 18;
            this.Detalles.TabStop = false;
            this.Detalles.Text = "Detalles";
            // 
            // BtnAgregarDetalle
            // 
            this.BtnAgregarDetalle.Location = new System.Drawing.Point(737, 28);
            this.BtnAgregarDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarDetalle.Name = "BtnAgregarDetalle";
            this.BtnAgregarDetalle.Size = new System.Drawing.Size(85, 34);
            this.BtnAgregarDetalle.TabIndex = 17;
            this.BtnAgregarDetalle.Text = "Agregar";
            this.BtnAgregarDetalle.UseVisualStyleBackColor = true;
            this.BtnAgregarDetalle.Click += new System.EventHandler(this.BtnAgregarDetalle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cuatrimestre";
            // 
            // TxtCuatri
            // 
            this.TxtCuatri.Location = new System.Drawing.Point(653, 34);
            this.TxtCuatri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCuatri.Name = "TxtCuatri";
            this.TxtCuatri.Size = new System.Drawing.Size(52, 22);
            this.TxtCuatri.TabIndex = 15;
            // 
            // TxtAño
            // 
            this.TxtAño.Location = new System.Drawing.Point(492, 34);
            this.TxtAño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAño.Name = "TxtAño";
            this.TxtAño.Size = new System.Drawing.Size(57, 22);
            this.TxtAño.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Año de Cursado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Asignatura";
            // 
            // CboAsignaturas
            // 
            this.CboAsignaturas.FormattingEnabled = true;
            this.CboAsignaturas.Location = new System.Drawing.Point(97, 33);
            this.CboAsignaturas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CboAsignaturas.Name = "CboAsignaturas";
            this.CboAsignaturas.Size = new System.Drawing.Size(261, 24);
            this.CboAsignaturas.TabIndex = 11;
            // 
            // DtgDetalles
            // 
            this.DtgDetalles.AllowUserToAddRows = false;
            this.DtgDetalles.AllowUserToDeleteRows = false;
            this.DtgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColAsignatura,
            this.ColAño,
            this.ColCuatri,
            this.ColQuitar});
            this.DtgDetalles.Location = new System.Drawing.Point(4, 82);
            this.DtgDetalles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtgDetalles.Name = "DtgDetalles";
            this.DtgDetalles.ReadOnly = true;
            this.DtgDetalles.RowHeadersWidth = 51;
            this.DtgDetalles.Size = new System.Drawing.Size(819, 224);
            this.DtgDetalles.TabIndex = 10;
            this.DtgDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgDetalles_CellContentClick);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            this.ColID.Width = 125;
            // 
            // ColAsignatura
            // 
            this.ColAsignatura.HeaderText = "Asignatura";
            this.ColAsignatura.MinimumWidth = 6;
            this.ColAsignatura.Name = "ColAsignatura";
            this.ColAsignatura.ReadOnly = true;
            this.ColAsignatura.Width = 260;
            // 
            // ColAño
            // 
            this.ColAño.HeaderText = "Año";
            this.ColAño.MinimumWidth = 6;
            this.ColAño.Name = "ColAño";
            this.ColAño.ReadOnly = true;
            this.ColAño.Width = 125;
            // 
            // ColCuatri
            // 
            this.ColCuatri.HeaderText = "Cuatrimestre";
            this.ColCuatri.MinimumWidth = 6;
            this.ColCuatri.Name = "ColCuatri";
            this.ColCuatri.ReadOnly = true;
            this.ColCuatri.Width = 125;
            // 
            // ColQuitar
            // 
            this.ColQuitar.HeaderText = "Quitar";
            this.ColQuitar.MinimumWidth = 6;
            this.ColQuitar.Name = "ColQuitar";
            this.ColQuitar.ReadOnly = true;
            this.ColQuitar.Text = "Quitar";
            this.ColQuitar.Width = 125;
            // 
            // FrmModificarDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 788);
            this.Controls.Add(this.Detalles);
            this.Controls.Add(this.GroupCarrera);
            this.Controls.Add(this.BtnListo);
            this.Controls.Add(this.Confirmar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmModificarDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModificarDetalles";
            this.Load += new System.EventHandler(this.FrmModificarDetalles_Load);
            this.GroupCarrera.ResumeLayout(false);
            this.GroupCarrera.PerformLayout();
            this.Detalles.ResumeLayout(false);
            this.Detalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Confirmar;
        private System.Windows.Forms.Button BtnListo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.GroupBox GroupCarrera;
        private System.Windows.Forms.GroupBox Detalles;
        private System.Windows.Forms.Button BtnAgregarDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCuatri;
        private System.Windows.Forms.TextBox TxtAño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboAsignaturas;
        private System.Windows.Forms.DataGridView DtgDetalles;
        private System.Windows.Forms.ListBox LstCarreras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuatri;
        private System.Windows.Forms.DataGridViewButtonColumn ColQuitar;
    }
}