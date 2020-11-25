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
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int fac = int.Parse(txtNumero.Text);
            fact(fac);
            txtFactorial.Text = fact(fac).ToString();

        }

        public static double fact(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            return num * fact(num - 1);
        }

    }
}
