namespace AppRadio2
{
    partial class txtnumero2
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
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.rdsuma = new System.Windows.Forms.RadioButton();
            this.rdresta = new System.Windows.Forms.RadioButton();
            this.lblnumero3 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(172, 57);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(100, 20);
            this.txtnumero1.TabIndex = 0;
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.Location = new System.Drawing.Point(37, 57);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(53, 13);
            this.lblnumero1.TabIndex = 1;
            this.lblnumero1.Text = "Numero 1";
            // 
            // lblnumero2
            // 
            this.lblnumero2.AutoSize = true;
            this.lblnumero2.Location = new System.Drawing.Point(37, 121);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(53, 13);
            this.lblnumero2.TabIndex = 3;
            this.lblnumero2.Text = "Numero 2";
            // 
            // rdsuma
            // 
            this.rdsuma.AutoSize = true;
            this.rdsuma.Location = new System.Drawing.Point(366, 57);
            this.rdsuma.Name = "rdsuma";
            this.rdsuma.Size = new System.Drawing.Size(52, 17);
            this.rdsuma.TabIndex = 4;
            this.rdsuma.TabStop = true;
            this.rdsuma.Text = "Suma";
            this.rdsuma.UseVisualStyleBackColor = true;
            // 
            // rdresta
            // 
            this.rdresta.AutoSize = true;
            this.rdresta.Location = new System.Drawing.Point(366, 116);
            this.rdresta.Name = "rdresta";
            this.rdresta.Size = new System.Drawing.Size(53, 17);
            this.rdresta.TabIndex = 5;
            this.rdresta.TabStop = true;
            this.rdresta.Text = "Resta";
            this.rdresta.UseVisualStyleBackColor = true;
            // 
            // lblnumero3
            // 
            this.lblnumero3.AutoSize = true;
            this.lblnumero3.Location = new System.Drawing.Point(37, 174);
            this.lblnumero3.Name = "lblnumero3";
            this.lblnumero3.Size = new System.Drawing.Size(58, 13);
            this.lblnumero3.TabIndex = 7;
            this.lblnumero3.Text = "Resultado:";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(172, 174);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 6;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(355, 174);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 8;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(172, 115);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(100, 20);
            this.txtBox1.TabIndex = 9;
            // 
            // txtnumero2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 326);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.lblnumero3);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.rdresta);
            this.Controls.Add(this.rdsuma);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.lblnumero1);
            this.Controls.Add(this.txtnumero1);
            this.Name = "txtnumero2";
            this.Text = "Programa Suma y Resta";
            this.Load += new System.EventHandler(this.txtnumero2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.Label lblnumero2;
        private System.Windows.Forms.RadioButton rdsuma;
        private System.Windows.Forms.RadioButton rdresta;
        private System.Windows.Forms.Label lblnumero3;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.TextBox txtBox1;
    }
}

