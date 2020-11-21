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
            frmHistorico FrmHistorico = new frmHistorico();
            FrmHistorico.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmHistorico.WindowState = FormWindowState.Maximized;
            FrmHistorico.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmL_Romaneios"];
            if (fc != null)
            {
                fc.Close();
            }
            Listar_Romaneios frmL_Romaneios = new Listar_Romaneios();
            frmL_Romaneios.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            frmL_Romaneios.WindowState = FormWindowState.Maximized;
            frmL_Romaneios.Show();
        }

        private void entregasPendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmEntregas"];
            if (fc != null)
            {
                fc.Close();
            }
            frmEntregas FrmEntregas = new frmEntregas();
            FrmEntregas.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmEntregas.WindowState = FormWindowState.Maximized;
            FrmEntregas.Show();
        }

        private void gerarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmCerarCTE"];
            if (fc != null)
            {
                fc.Close();
            }
            frmCerarCTE FrmGerarCte = new frmCerarCTE();
            FrmGerarCte.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmGerarCte.WindowState = FormWindowState.Maximized;
            FrmGerarCte.Show();
        }

        private void calcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmCalcularFrete"];
            if (fc != null)
            {
                fc.Close();
            }
            frmCalcularFrete FrmCalcularFrete = new frmCalcularFrete();
            FrmCalcularFrete.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmCalcularFrete.WindowState = FormWindowState.Maximized;
            FrmCalcularFrete.Show();
        }

        private void gerarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmCadastro_Romaneio"];
            if (fc != null)
            {
                fc.Close();
            }
            frmCadastro_Romaneio FrmCalcularRomaneio = new frmCadastro_Romaneio();
            FrmCalcularRomaneio.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmCalcularRomaneio.WindowState = FormWindowState.Maximized;
            FrmCalcularRomaneio.Show();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmCadastro_veiculo"];
            if (fc != null)
            {
                fc.Close();
            }
            frmCadastro_veiculo FrmCadVeiculos = new frmCadastro_veiculo();
            FrmCadVeiculos.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmCadVeiculos.WindowState = FormWindowState.Maximized;
            FrmCadVeiculos.Show();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmAlterar_Veiculos"];
            if (fc != null)
            {
                fc.Close();
            }
            frmAlterar_Veiculos FrmAltVeiculos = new frmAlterar_Veiculos();
            FrmAltVeiculos.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmAltVeiculos.WindowState = FormWindowState.Maximized;
            FrmAltVeiculos.Show();
        }

        private void listarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmL_Veiculos"];
            if (fc != null)
            {
                fc.Close();
            }
            frmL_Veiculos FrmListaVeiculos = new frmL_Veiculos();
            FrmListaVeiculos.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmListaVeiculos.WindowState = FormWindowState.Maximized;
            FrmListaVeiculos.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmCadastro_Transportadores"];
            if (fc != null)
            {
                fc.Close();
            }
            frmCadastro_Transportadores FrmCadTransportadores = new frmCadastro_Transportadores();
            FrmCadTransportadores.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmCadTransportadores.WindowState = FormWindowState.Maximized;
            FrmCadTransportadores.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmAlterar_Transportadores"];
            if (fc != null)
            {
                fc.Close();
            }
            frmAlterar_Transportadores FrmAltTransportadores = new frmAlterar_Transportadores();
            FrmAltTransportadores.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmAltTransportadores.WindowState = FormWindowState.Maximized;
            FrmAltTransportadores.Show();
        }

        private void listarTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmL_Transportadores"];
            if (fc != null)
            {
                fc.Close();
            }
            frmL_Transportadores FrmListarTransportadores = new frmL_Transportadores();
            FrmListarTransportadores.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmListarTransportadores.WindowState = FormWindowState.Maximized;
            FrmListarTransportadores.Show();
        }

        private void inserirNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmReceberNFe"];
            if (fc != null)
            {
                fc.Close();
            }
            frmReceberNFe FrmReceberNFE = new frmReceberNFe();
            FrmReceberNFE.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmReceberNFE.WindowState = FormWindowState.Maximized;
            FrmReceberNFE.Show();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmLogin"];
            if (fc != null)
            {
                fc.Close();
            }
            frmLogin Frmlogin = new frmLogin();
            Frmlogin.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            Frmlogin.WindowState = FormWindowState.Maximized;
            Frmlogin.Show();
        }

        private void verPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmCadastro_Func"];
            if (fc != null)
            {
                fc.Close();
            }
            frmCadastro_Func FrmCadfunc = new frmCadastro_Func();
            FrmCadfunc.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmCadfunc.WindowState = FormWindowState.Maximized;
            FrmCadfunc.Show();
        }

        private void alterarRomaneioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmAlterar_Romaneio"];
            if (fc != null)
            {
                fc.Close();
            }
            frmAlterar_Romaneio FrmAltRomaneio = new frmAlterar_Romaneio();
            FrmAltRomaneio.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmAltRomaneio.WindowState = FormWindowState.Maximized;
            FrmAltRomaneio.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmVisualizar_CTes"];
            if (fc != null)
            {
                fc.Close();
            }
            frmVisualizar_CTes FrmListarCtes = new frmVisualizar_CTes();
            FrmListarCtes.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmListarCtes.WindowState = FormWindowState.Maximized;
            FrmListarCtes.Show();
        }

        private void gerarRotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmCalcular_rota"];
            if (fc != null)
            {
                fc.Close();
            }
            frmCalcular_rota FrmCalcRota = new frmCalcular_rota();
            FrmCalcRota.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmCalcRota.WindowState = FormWindowState.Maximized;
            FrmCalcRota.Show();
        }

        private void cadastrarMotoristasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbFundo.Hide();
            Form fc = Application.OpenForms["frmMotoristas"];
            if (fc != null)
            {
                fc.Close();
            }
            frmMotoristas FrmMotorista = new frmMotoristas();
            FrmMotorista.MdiParent = this; // anexar o form 'filho' dentro do form 'pai'
            FrmMotorista.WindowState = FormWindowState.Maximized;
            FrmMotorista.Show();
        }
    }
}
