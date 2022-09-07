namespace Carrera1._1.Presentacion
{
    partial class ABMAsignaturas
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
            this.LstAsignaturas = new System.Windows.Forms.ListBox();
            this.BtnNueva = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstAsignaturas
            // 
            this.LstAsignaturas.FormattingEnabled = true;
            this.LstAsignaturas.ItemHeight = 16;
            this.LstAsignaturas.Location = new System.Drawing.Point(12, 12);
            this.LstAsignaturas.Name = "LstAsignaturas";
            this.LstAsignaturas.Size = new System.Drawing.Size(352, 388);
            this.LstAsignaturas.TabIndex = 0;
            // 
            // BtnNueva
            // 
            this.BtnNueva.Location = new System.Drawing.Point(12, 406);
            this.BtnNueva.Name = "BtnNueva";
            this.BtnNueva.Size = new System.Drawing.Size(75, 32);
            this.BtnNueva.TabIndex = 1;
            this.BtnNueva.Text = "Nueva";
            this.BtnNueva.UseVisualStyleBackColor = true;
            this.BtnNueva.Click += new System.EventHandler(this.BtnNueva_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(150, 406);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 32);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(288, 406);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 32);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // ABMAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnNueva);
            this.Controls.Add(this.LstAsignaturas);
            this.Name = "ABMAsignaturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMAsignaturas";
            this.Load += new System.EventHandler(this.ABMAsignaturas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstAsignaturas;
        private System.Windows.Forms.Button BtnNueva;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}