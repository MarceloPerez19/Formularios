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
    public partial class frmMenu : Form
    {
        private int childFormNumber = 0;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //abrir el formulario entero en binario
            frmNumeroEnBinario frm1 = new frmNumeroEnBinario();
            frm1.MdiParent = this; //this es el formulario actual. establece como formulario padre, el menu 
            frm1.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            frmSueldo frm1 = new frmSueldo();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Primo frm1 = new Primo();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNombreEdad frm1 = new frmNombreEdad();
            frm1.MdiParent=this;
            frm1.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrCalendario frm1 = new fmrCalendario();
            frm1.MdiParent=this;
            frm1.Show();
        }

        private void binarioADecimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBinarioaDcecimal frm1 = new frmBinarioaDcecimal();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void factorialDeUnNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactorial frm1 = new frmFactorial();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void miltiplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMultiplicar frm1 = new frmMultiplicar();
            frm1.MdiParent = this;
            frm1.Show();
        }
    }
}
