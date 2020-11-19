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
            //validaciones
            if(this.txtNombre.Text.Length==0)
            {
                MessageBox.Show("Por favor debes ingresar el nombre");
                this.txtNombre.Focus(); //ubica el curso en un control
                return; //abandonar
            }

            if (this.txtAsoTrabajadores.Text.Length == 0)
            {
                MessageBox.Show("Por favor debes ingresar la Aso. de trabajadores");
                this.txtAsoTrabajadores.Focus(); 
                return; 
            }

            if (this.txtBar.Text.Length == 0)
            {
                MessageBox.Show("Por favor debes ingresar el Bar");
                this.txtBar.Focus(); 
                return; 
            }

            if (this.txtBono.Text.Length == 0)
            {
                MessageBox.Show("Por favor debes ingresar el bono");
                this.txtBono.Focus(); 
                return; 
            }

            if (this.txtCuentaPagar.Text.Length == 0)
            {
                MessageBox.Show("Por favor debes ingresar las cuentas por pagar");
                this.txtCuentaPagar.Focus(); 
                return; 
            }

            if (this.txtHorasTrab.Text.Length == 0)
            {
                MessageBox.Show("Por favor debes ingresar las horas trabajadas");
                this.txtHorasTrab.Focus(); 
                return; 
            }

            if (this.txtValorHora.Text.Length == 0)
            {
                MessageBox.Show("Por favor debes ingresar el valor por hora");
                this.txtValorHora.Focus(); 
                return; 
            }

           

            //tarea
            //1. validar el ingreso de todos los cuadros de textos
            //2. validar que el dato ingresado sea numerico 
            //no usar tray..catc
            //traycatch modelo hacerlo para validar cuadros de texto

            /*if(Double.TryParse(txtHorasTrab.Text, out double HorasTrab)==false)
            {
                MessageBox.Show("Por favor solo ingresa valores numericos...");
                this.txtHorasTrab.Focus();
                return;
            }*/

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

            //liquido
            double liquidoRecibir = totIng - totEgre;
            lblResultado.Text = "Estimado " + this.txtNombre.Text + " tu sueldo es : " + liquidoRecibir.ToString();
        }

        private void txtHorasTrab_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //cerrar el formulario 
        }

        private void txtHorasTrab_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.Numeros(e);
        }

        private void txtValorHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.Numeros(e);
        }

        private void txtBono_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.Numeros(e);
        }

        private void txtAsoTrabajadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.Numeros(e);
        }

        private void txtBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.Numeros(e);
        }

        private void txtCuentaPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.Numeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            vali.Letras(e);
        }
    }
}
