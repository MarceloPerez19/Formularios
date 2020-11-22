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
    public partial class frmNombreEdad : Form
    {
        public frmNombreEdad()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            int edad = int.Parse(txtEdad.Text);

            if (edad >= 15 && edad <= 80)
            {
                if (edad >= 15 && edad <= 17)
                {

                    txtVNombre.Text = txtNombre.Text + " Eres menor de edad";
                    txtVNombre.Visible = true;
                }
                else if (edad >= 18 && edad <= 25)
                {

                    txtVNombre.Text = txtNombre.Text + " Puedes votar en las elecciones 2021";
                    txtVNombre.Visible = true;
                }
                else if (edad >= 26 && edad <= 30)
                {

                    txtVNombre.Text = txtNombre.Text + " Ya debes casarte";
                    txtVNombre.Visible = true;
                }
                else if (edad >= 31 && edad <= 50)
                {

                    txtVNombre.Text = txtNombre.Text + " Trabaja, duerme y disfruta ";
                    txtVNombre.Visible = true;
                }
                else if (edad > 50)
                {

                    txtVNombre.Text = txtNombre.Text + " Ya casi estas en la tercera edad";
                    txtVNombre.Visible = true;
                }
                else if (edad > 80)
                {
                    txtVNombre.Text = txtNombre.Text + " Ya casi estas en la tercera edad";
                    txtVNombre.Visible = true;
                }
            }
            else if(edad>80)
            {
                txtVNombre.Text = txtNombre.Text + " Usted ya es de la tercera edad";
                txtVNombre.Visible = true;
            }

        }
    }
}
