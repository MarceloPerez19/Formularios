using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    class vali
    {
        public static void Numeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        public static void Letras(KeyPressEventArgs pE)
        {
            if(char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if(char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if(char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }
    }
}
