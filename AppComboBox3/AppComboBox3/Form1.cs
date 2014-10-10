using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppComboBox3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            String pais = " ";
            Text = txtnombre.Text + "  " + cmbpais.Text;
        }

        private void cmbpais_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
