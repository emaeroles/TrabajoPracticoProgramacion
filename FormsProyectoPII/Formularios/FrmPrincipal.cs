using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsProyectoPII
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void FrmPrincipal_Shown(object sender, EventArgs e)
        {
            FrmLogin frmlogin = new FrmLogin();
            frmlogin.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pPrincipal.Controls.Clear();
            pPrincipal.Controls.Add(gbPrincipal);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pPrincipal.Controls.Clear();
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.TopLevel = false;
            pPrincipal.Controls.Add(frmUsuarios);
            frmUsuarios.Show();
        }

        private void camionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pPrincipal.Controls.Clear();
            FrmCamiones frmCamiones = new FrmCamiones();
            frmCamiones.TopLevel = false;
            pPrincipal.Controls.Add(frmCamiones);
            frmCamiones.Show();
        }

        private void viajesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pPrincipal.Controls.Clear();
            FrmViajes frmViajes = new FrmViajes();
            frmViajes.TopLevel = false;
            pPrincipal.Controls.Add(frmViajes);
            frmViajes.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pPrincipal.Controls.Clear();
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe();
            frmAcercaDe.TopLevel = false;
            pPrincipal.Controls.Add(frmAcercaDe);
            frmAcercaDe.Show();
        }

        private void reportesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pPrincipal.Controls.Clear();
            FrmReportes frmReportes = new FrmReportes();
            frmReportes.TopLevel = false;
            pPrincipal.Controls.Add(frmReportes);
            frmReportes.Show();
        }
    }
}
