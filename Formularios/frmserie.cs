﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmserie : Form
    {
        public frmserie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int limite = int.Parse(this.txtLimite.Text);
            long cad = TIC.utilidades.Serie(limite);
            this.txtResultado.Text = cad.ToString();
        }
    }
}
