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
    public partial class frmPartesComputador : Form
    {
        public frmPartesComputador()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string cad = " ";
            if (this.radioButton4GB.Checked == true)
            {
                cad = "Computadora con 4 GB de Memoria RAM  ";
            }
            else if (this.radioButton8GB.Checked == true)
            {
                cad = "Compuradora con 8 GB de Memoria RAM  ";
            }
            else if (this.radioButton12GB.Checked == true)
            {
                cad = "Compurtadora con 12 GB de Memoria RAM  ";
            }

            this.txtResultado.Text = cad;

            if(this.radioButton80GB.Checked==true)
            {
                cad+= "Computadora con 80 GB de almacenamiento  ";
            }
            else if(this.radioButton300GB.Checked==true)
            {
                cad+= "Computadora con 300 GB de almacenamiento  ";
            }
            else if(this.radioButton500GB.Checked==true)
            {
                cad+= "Computadora de 500 GB de almacenamiento  ";
            }
            this.txtResultado.Text = cad;

            if(this.radioButtonI3.Checked==true)
            {
                cad+= "Computadora con procesador I3  ";
            }
            else if(this.radioButtonI5.Checked==true)
            {
                cad+= "Computadora con procesador I5  ";
            }
            else if(this.radioButtonI7.Checked==true)
            {
                cad+= "Computadora con procesador I/  ";
            }
            this.txtResultado.Text = cad;

            if(this.camara.Checked==true)
            {
                cad+= "La computadora tiene camara  ";
            }
            if(this.mouse.Checked==true)
            {
                cad+= "La computadora tiene mouse  ";
            }
            if(this.impresora.Checked==true)
            {
                cad+= "La computadora tiene impresora  ";
            }
            this.txtResultado.Text = cad;
           
        }
    }
}
