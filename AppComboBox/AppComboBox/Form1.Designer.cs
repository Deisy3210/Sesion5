namespace AppComboBox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbcolor = new System.Windows.Forms.ComboBox();
            this.lblcolor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbcolor
            // 
            this.cmbcolor.FormattingEnabled = true;
            this.cmbcolor.Items.AddRange(new object[] {
            "ROJO",
            "AMARILLO",
            "AZUL",
            "ROSADO",
            "VIOLETA"});
            this.cmbcolor.Location = new System.Drawing.Point(151, 48);
            this.cmbcolor.Name = "cmbcolor";
            this.cmbcolor.Size = new System.Drawing.Size(121, 21);
            this.cmbcolor.TabIndex = 0;
            this.cmbcolor.SelectedIndexChanged += new System.EventHandler(this.cmbcolor_SelectedIndexChanged);
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Location = new System.Drawing.Point(34, 51);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(31, 13);
            this.lblcolor.TabIndex = 1;
            this.lblcolor.Text = "Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 262);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.cmbcolor);
            this.Name = "Form1";
            this.Text = "Programa Color";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbcolor;
        private System.Windows.Forms.Label lblcolor;
    }
}

