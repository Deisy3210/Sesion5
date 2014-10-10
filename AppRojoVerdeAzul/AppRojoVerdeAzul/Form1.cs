﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRojoVerdeAzul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int ch = 0; ch <= 255; ch++)
            {
                cmbrojo.Items.Add(ch);
                cmbazul.Items.Add(ch);
                cmbverde.Items.Add(ch);
            }

            cmbrojo.SelectedIndex = 0;
            cmbazul.SelectedIndex = 0;
            cmbverde.SelectedIndex = 0;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            int rojo, azul, verde;

            rojo = int.Parse(cmbrojo.Text);
            azul = int.Parse(cmbazul.Text);
            verde = int.Parse(cmbverde.Text);
            BackColor = Color.FromArgb(rojo, azul, verde);

        }
    }
}
