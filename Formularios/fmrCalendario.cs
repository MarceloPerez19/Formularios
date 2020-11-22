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
    public partial class fmrCalendario : Form
    {
        public fmrCalendario()
        {
            InitializeComponent();
        }

        private void lblFecha_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            lblFecha.Text = fecha.ToString();
            DateTime Actual = DateTime.Today;
            int Allos = Actual.Year - dateTimePicker1.Value.Year;
            int Dias = ((Actual.Year - dateTimePicker1.Value.Year) * 365) + ((Actual.Month - dateTimePicker1.Value.Month) * 31)+ Actual.Day - dateTimePicker1.Value.Day;
            txtAllos.Text = Allos.ToString() + " Tiempo en años";
            txtDias.Text = Dias.ToString() + " Tiempo en Días";
        }
    }
}
