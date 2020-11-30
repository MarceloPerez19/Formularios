using System;
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
    public partial class frmInvertido : Form
    {
        public frmInvertido()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int entero = int.Parse(this.txtEntero.Text);
            int f, re;

            f = entero % 10;
            entero = entero / 10;
            re = f * 10;

            f = entero % 10;
            entero = entero / 10;
            re = (re + f)*10;

            f = entero % 10;
            entero = entero / 10;
            re= (re + f) * 10;

            f = entero % 10;
            entero = entero / 10;
            re = (re + f) * 10;

            f = entero % 10;
            entero = entero / 10;
            re = (re + f) * 10;

            re = re + f;

            this.txtResultado.Text = re.ToString();



        }
    }
}
