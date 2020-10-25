using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protótipo_EngSoft
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void entregasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmHistorico"];
            if (fc != null)
            {
                fc.Close();
            }
            Listar_Veiculos_Registrados FrmHistorico = new Listar_Veiculos_Registrados();
            FrmHistorico.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmHistorico.WindowState = FormWindowState.Maximized;
            FrmHistorico.Show();
        }
    }
}
