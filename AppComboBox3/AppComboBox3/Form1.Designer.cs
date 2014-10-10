namespace AppComboBox3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cmbpais = new System.Windows.Forms.ComboBox();
            this.btncambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pais:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(130, 29);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // cmbpais
            // 
            this.cmbpais.FormattingEnabled = true;
            this.cmbpais.Items.AddRange(new object[] {
            "Colombia",
            "Argentina",
            "Venezuela",
            "Ecuador"});
            this.cmbpais.Location = new System.Drawing.Point(130, 75);
            this.cmbpais.Name = "cmbpais";
            this.cmbpais.Size = new System.Drawing.Size(121, 21);
            this.cmbpais.TabIndex = 3;
            this.cmbpais.SelectedIndexChanged += new System.EventHandler(this.cmbpais_SelectedIndexChanged);
            // 
            // btncambiar
            // 
            this.btncambiar.Location = new System.Drawing.Point(104, 130);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(75, 23);
            this.btncambiar.TabIndex = 4;
            this.btncambiar.Text = "Cambar";
            this.btncambiar.UseVisualStyleBackColor = true;
            this.btncambiar.Click += new System.EventHandler(this.btncambiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 262);
            this.Controls.Add(this.btncambiar);
            this.Controls.Add(this.cmbpais);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cmbpais;
        private System.Windows.Forms.Button btncambiar;
    }
}

