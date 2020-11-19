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
    public partial class frmBinarioaDcecimal : Form
    {
        public frmBinarioaDcecimal()
        {
            InitializeComponent();
        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
        }

        private void frmBinarioaDcecimal_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            {
                double acu = 0;
                double num = 0;
                
                    if (this.chk8.Checked == true)
                    {
                        acu = Math.Pow(2, 0);
                        num += acu; 
                    }
                    if (this.chk7.Checked == true)
                    {
                        acu = Math.Pow(2, 1);
                        num += acu;

                    }
                    if (this.chk6.Checked == true)
                    {
                        acu = Math.Pow(2, 2);
                        num += acu;
                    }
                    if (this.chk5.Checked == true)
                    {
                        acu = Math.Pow(2, 3);
                        num += acu;
                    }
                    if (this.chk4.Checked == true)
                    {
                        acu = Math.Pow(2, 4);
                        num += acu;
                    }
                    if (this.chk3.Checked == true)
                    {
                        acu = Math.Pow(2, 5);
                        num += acu;
                    }
                    if (this.chk2.Checked == true)
                    {
                        acu = Math.Pow(2, 6);
                        num += acu;
                    }
                    if (this.chk1.Checked == true)
                    {
                        acu = Math.Pow(2, 7);
                        num += acu;
                    }
                    txtResultado.Text = num.ToString();
                
            }
        }
    }
}
