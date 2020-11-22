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
    public partial class Primo : Form
    {
        public Primo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNumero.Text);
            primo(a);
        }
        void primo(int a)
        {
            int cont = 0;
            for (int q=1; q<=a;q++)
            {
                if (a % q == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                label2.Text=(Convert.ToString(a + " Es primo primo"));
                label2.Visible = true;
            }
            else
            {
                label2.Text = (Convert.ToString(a + " No es primo"));
                label2.Visible = true;
            }
        }
        }
    }

