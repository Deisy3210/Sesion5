namespace AppRojoVerdeAzul
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
            this.lblrojo = new System.Windows.Forms.Label();
            this.lblazul = new System.Windows.Forms.Label();
            this.lblverde = new System.Windows.Forms.Label();
            this.cmbrojo = new System.Windows.Forms.ComboBox();
            this.cmbazul = new System.Windows.Forms.ComboBox();
            this.cmbverde = new System.Windows.Forms.ComboBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblrojo
            // 
            this.lblrojo.AutoSize = true;
            this.lblrojo.Location = new System.Drawing.Point(67, 80);
            this.lblrojo.Name = "lblrojo";
            this.lblrojo.Size = new System.Drawing.Size(29, 13);
            this.lblrojo.TabIndex = 0;
            this.lblrojo.Text = "Rojo";
            // 
            // lblazul
            // 
            this.lblazul.AutoSize = true;
            this.lblazul.Location = new System.Drawing.Point(67, 119);
            this.lblazul.Name = "lblazul";
            this.lblazul.Size = new System.Drawing.Size(27, 13);
            this.lblazul.TabIndex = 1;
            this.lblazul.Text = "Azul";
            // 
            // lblverde
            // 
            this.lblverde.AutoSize = true;
            this.lblverde.Location = new System.Drawing.Point(67, 157);
            this.lblverde.Name = "lblverde";
            this.lblverde.Size = new System.Drawing.Size(35, 13);
            this.lblverde.TabIndex = 2;
            this.lblverde.Text = "Verde";
            // 
            // cmbrojo
            // 
            this.cmbrojo.FormattingEnabled = true;
            this.cmbrojo.Location = new System.Drawing.Point(246, 80);
            this.cmbrojo.Name = "cmbrojo";
            this.cmbrojo.Size = new System.Drawing.Size(121, 21);
            this.cmbrojo.TabIndex = 3;
            // 
            // cmbazul
            // 
            this.cmbazul.FormattingEnabled = true;
            this.cmbazul.Location = new System.Drawing.Point(246, 119);
            this.cmbazul.Name = "cmbazul";
            this.cmbazul.Size = new System.Drawing.Size(121, 21);
            this.cmbazul.TabIndex = 4;
            // 
            // cmbverde
            // 
            this.cmbverde.FormattingEnabled = true;
            this.cmbverde.Location = new System.Drawing.Point(246, 157);
            this.cmbverde.Name = "cmbverde";
            this.cmbverde.Size = new System.Drawing.Size(121, 21);
            this.cmbverde.TabIndex = 5;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(167, 243);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 6;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 355);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.cmbverde);
            this.Controls.Add(this.cmbazul);
            this.Controls.Add(this.cmbrojo);
            this.Controls.Add(this.lblverde);
            this.Controls.Add(this.lblazul);
            this.Controls.Add(this.lblrojo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrojo;
        private System.Windows.Forms.Label lblazul;
        private System.Windows.Forms.Label lblverde;
        private System.Windows.Forms.ComboBox cmbrojo;
        private System.Windows.Forms.ComboBox cmbazul;
        private System.Windows.Forms.ComboBox cmbverde;
        private System.Windows.Forms.Button btnactualizar;
    }
}

