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
    public partial class frmSueldo : Form
    {
        public frmSueldo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //sumar los ingresos
            double horasTrabajadas = double.Parse( this.txtHorasTrab.Text);
            double valorHora = double.Parse(this.txtValorHora.Text);
            double bono = double.Parse(this.txtBono.Text);
            double totIng = horasTrabajadas * valorHora + bono ;

            //mostrar el total de ingresos en el cuadro de texto 
            this.txtTotalIng.Text = totIng.ToString();

            //sumar los egresos
            double AsoTrabajadores = double.Parse(this.txtAsoTrabajadores.Text);
            double Bar = double.Parse(this.txtBar.Text);
            double cuentaPago = double.Parse(this.txtCuentaPagar.Text);
            double totEgre = AsoTrabajadores + Bar + cuentaPago;

            //mostrar el total de egresos en el cuadro de texto 
            this.txtTotalEgresos.Text = totEgre.ToString();
            double liquidoRecibir = totIng - totEgre;
            lblResultado.Text = "Estimado " + this.txtNombre.Text + " tu sueldo es : " + liquidoRecibir.ToString();
        }

        private void txtHorasTrab_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
