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
    public partial class frmMultiplicar : Form
    {
        public frmMultiplicar()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int tabla = int.Parse(txtNumero.Text);
            int resultado;

            for(int a=1; a<=12; a++)
            {
                resultado = tabla * a;
                listBox1.Items.Add(tabla + " x " + a + " = " + resultado);
            }
        }
    }
}
