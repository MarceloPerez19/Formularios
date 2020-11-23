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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSueldo_Click(object sender, EventArgs e)
        {
            //abrir el formulario que calcula sueldo
            //crear una instancia del formulario
            frmSueldo frm1 = new frmSueldo();
            frm1.Show();//mostrar el formulario
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBinario_Click(object sender, EventArgs e)
        {
            frmBinarioaDcecimal frm1 = new frmBinarioaDcecimal();
            frm1.ShowDialog();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            frmNombreEdad frm1 = new frmNombreEdad();
            frm1.ShowDialog();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            fmrCalendario frm1 = new fmrCalendario();
            frm1.ShowDialog();
        }
    }
}
