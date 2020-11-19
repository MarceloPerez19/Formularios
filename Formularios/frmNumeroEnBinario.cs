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
    public partial class frmNumeroEnBinario : Form
    {
        public frmNumeroEnBinario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //todo: validar que sea valores numericos 

            //validar que este en el rango de 0 a 255
            int num = Int32.Parse(this.txtNumero.Text);
            if(!(num>=0 && num<=255))
            {
                MessageBox.Show("Tu numero debe estar en el rango 0..255");
                this.txtNumero.Focus();
                return;
            }

            numeroaBinario(num);
            
        }//fin boton calcular

        

        void numeroaBinario(int num)
        {
            //bucle para tranformar el numero en binario
            int cont = 9;
            while (num > 0)
            {
                int residuo = num % 2; //operador para guardar el residuo %
                cont--;
                if (cont == 8)
                    this.chk8.Checked = residuo == 0 ? false : true;
                else if (cont == 7)
                    this.chk7.Checked = residuo == 0 ? false : true;
                else if (cont == 6)
                    this.chk6.Checked = residuo == 0 ? false : true;
                else if (cont == 5)
                    this.chk5.Checked = residuo == 0 ? false : true;
                else if (cont == 4)
                    this.chk4.Checked = residuo == 0 ? false : true;
                else if (cont == 3)
                    this.chk3.Checked = residuo == 0 ? false : true;
                else if (cont == 27)
                    this.chk2.Checked = residuo == 0 ? false : true;
                else if (cont == 1)
                    this.chk1.Checked = residuo == 0 ? false : true;


                num = num / 2;

            } //fin de bucle while
        }
    }//fin de la clase
}//fin de namespace
