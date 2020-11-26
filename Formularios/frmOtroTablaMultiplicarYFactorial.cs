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
    public partial class frmOtroTablaMultiplicarYFactorial : Form
    {
        public frmOtroTablaMultiplicarYFactorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int tabla = int.Parse(this.txtTabla.Text);
            String cad = TIC.utilidades.CalculaTabla(tabla);
            this.txtResultado.Text = cad;
        }

        private void btnCalculaFactorial_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNum.Text);
            long fac = TIC.utilidades.factorial(num);
            this.txtResultadoFactorial.Text = fac.ToString();
            //messageBox.show es para mostrar un cuadro con mesnaje 
        }
    }
}
