﻿namespace Protótipo_EngSoft
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receberNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romaneioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarRomaneioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularFreteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acompanhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasPendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarRotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasRealizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbFundo = new System.Windows.Forms.PictureBox();
            this.cadastrarMotoristasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.receberNotaToolStripMenuItem,
            this.transportadoresToolStripMenuItem,
            this.veículosToolStripMenuItem,
            this.romaneioToolStripMenuItem,
            this.calcularFreteToolStripMenuItem,
            this.cTEToolStripMenuItem,
            this.acompanhamentoToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoffToolStripMenuItem,
            this.verPerfilToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.logoffToolStripMenuItem.Text = "Logoff";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // verPerfilToolStripMenuItem
            // 
            this.verPerfilToolStripMenuItem.Name = "verPerfilToolStripMenuItem";
            this.verPerfilToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.verPerfilToolStripMenuItem.Text = "Ver perfil";
            this.verPerfilToolStripMenuItem.Click += new System.EventHandler(this.verPerfilToolStripMenuItem_Click);
            // 
            // receberNotaToolStripMenuItem
            // 
            this.receberNotaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirNotaToolStripMenuItem,
            this.listarNotasToolStripMenuItem});
            this.receberNotaToolStripMenuItem.Name = "receberNotaToolStripMenuItem";
            this.receberNotaToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.receberNotaToolStripMenuItem.Text = "Receber Nota";
            // 
            // inserirNotaToolStripMenuItem
            // 
            this.inserirNotaToolStripMenuItem.Name = "inserirNotaToolStripMenuItem";
            this.inserirNotaToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.inserirNotaToolStripMenuItem.Text = "Consultar Chave Acesso";
            this.inserirNotaToolStripMenuItem.Click += new System.EventHandler(this.inserirNotaToolStripMenuItem_Click);
            // 
            // listarNotasToolStripMenuItem
            // 
            this.listarNotasToolStripMenuItem.Name = "listarNotasToolStripMenuItem";
            this.listarNotasToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.listarNotasToolStripMenuItem.Text = "Listar Notas";
            // 
            // transportadoresToolStripMenuItem
            // 
            this.transportadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.listarTodosToolStripMenuItem1,
            this.cadastrarMotoristasToolStripMenuItem});
            this.transportadoresToolStripMenuItem.Name = "transportadoresToolStripMenuItem";
            this.transportadoresToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.transportadoresToolStripMenuItem.Text = "Transportadores";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar ";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // listarTodosToolStripMenuItem1
            // 
            this.listarTodosToolStripMenuItem1.Name = "listarTodosToolStripMenuItem1";
            this.listarTodosToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.listarTodosToolStripMenuItem1.Text = "Listar Todos";
            this.listarTodosToolStripMenuItem1.Click += new System.EventHandler(this.listarTodosToolStripMenuItem1_Click);
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.alterarToolStripMenuItem1,
            this.listarTodosToolStripMenuItem});
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.veículosToolStripMenuItem.Text = "Veículos";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // alterarToolStripMenuItem1
            // 
            this.alterarToolStripMenuItem1.Name = "alterarToolStripMenuItem1";
            this.alterarToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.alterarToolStripMenuItem1.Text = "Alterar";
            this.alterarToolStripMenuItem1.Click += new System.EventHandler(this.alterarToolStripMenuItem1_Click);
            // 
            // listarTodosToolStripMenuItem
            // 
            this.listarTodosToolStripMenuItem.Name = "listarTodosToolStripMenuItem";
            this.listarTodosToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.listarTodosToolStripMenuItem.Text = "Listar Todos";
            this.listarTodosToolStripMenuItem.Click += new System.EventHandler(this.listarTodosToolStripMenuItem_Click);
            // 
            // romaneioToolStripMenuItem
            // 
            this.romaneioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarNovoToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.alterarRomaneioToolStripMenuItem});
            this.romaneioToolStripMenuItem.Name = "romaneioToolStripMenuItem";
            this.romaneioToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.romaneioToolStripMenuItem.Text = "Romaneio";
            // 
            // gerarNovoToolStripMenuItem
            // 
            this.gerarNovoToolStripMenuItem.Name = "gerarNovoToolStripMenuItem";
            this.gerarNovoToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.gerarNovoToolStripMenuItem.Text = "Gerar Novo";
            this.gerarNovoToolStripMenuItem.Click += new System.EventHandler(this.gerarNovoToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.listarToolStripMenuItem.Text = "Listar Todos";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // alterarRomaneioToolStripMenuItem
            // 
            this.alterarRomaneioToolStripMenuItem.Name = "alterarRomaneioToolStripMenuItem";
            this.alterarRomaneioToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.alterarRomaneioToolStripMenuItem.Text = "Alterar Romaneio";
            this.alterarRomaneioToolStripMenuItem.Click += new System.EventHandler(this.alterarRomaneioToolStripMenuItem_Click);
            // 
            // calcularFreteToolStripMenuItem
            // 
            this.calcularFreteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularToolStripMenuItem});
            this.calcularFreteToolStripMenuItem.Name = "calcularFreteToolStripMenuItem";
            this.calcularFreteToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.calcularFreteToolStripMenuItem.Text = "Calcular Frete";
            // 
            // calcularToolStripMenuItem
            // 
            this.calcularToolStripMenuItem.Name = "calcularToolStripMenuItem";
            this.calcularToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.calcularToolStripMenuItem.Text = "Calcular";
            this.calcularToolStripMenuItem.Click += new System.EventHandler(this.calcularToolStripMenuItem_Click);
            // 
            // cTEToolStripMenuItem
            // 
            this.cTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.cTEToolStripMenuItem.Name = "cTEToolStripMenuItem";
            this.cTEToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.cTEToolStripMenuItem.Text = "CT-E";
            // 
            // gerarToolStripMenuItem
            // 
            this.gerarToolStripMenuItem.Name = "gerarToolStripMenuItem";
            this.gerarToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.gerarToolStripMenuItem.Text = "Gerar";
            this.gerarToolStripMenuItem.Click += new System.EventHandler(this.gerarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // acompanhamentoToolStripMenuItem
            // 
            this.acompanhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entregasPendentesToolStripMenuItem,
            this.gerarRotaToolStripMenuItem});
            this.acompanhamentoToolStripMenuItem.Name = "acompanhamentoToolStripMenuItem";
            this.acompanhamentoToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.acompanhamentoToolStripMenuItem.Text = "Acompanhamento";
            // 
            // entregasPendentesToolStripMenuItem
            // 
            this.entregasPendentesToolStripMenuItem.Name = "entregasPendentesToolStripMenuItem";
            this.entregasPendentesToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.entregasPendentesToolStripMenuItem.Text = "Entregas pendentes";
            this.entregasPendentesToolStripMenuItem.Click += new System.EventHandler(this.entregasPendentesToolStripMenuItem_Click);
            // 
            // gerarRotaToolStripMenuItem
            // 
            this.gerarRotaToolStripMenuItem.Name = "gerarRotaToolStripMenuItem";
            this.gerarRotaToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.gerarRotaToolStripMenuItem.Text = "Gerar Rota";
            this.gerarRotaToolStripMenuItem.Click += new System.EventHandler(this.gerarRotaToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entregasRealizadasToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // entregasRealizadasToolStripMenuItem
            // 
            this.entregasRealizadasToolStripMenuItem.Name = "entregasRealizadasToolStripMenuItem";
            this.entregasRealizadasToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.entregasRealizadasToolStripMenuItem.Text = "Histórico";
            this.entregasRealizadasToolStripMenuItem.Click += new System.EventHandler(this.entregasRealizadasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pbFundo
            // 
            this.pbFundo.Image = ((System.Drawing.Image)(resources.GetObject("pbFundo.Image")));
            this.pbFundo.Location = new System.Drawing.Point(0, 31);
            this.pbFundo.Name = "pbFundo";
            this.pbFundo.Size = new System.Drawing.Size(1100, 540);
            this.pbFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFundo.TabIndex = 2;
            this.pbFundo.TabStop = false;
            // 
            // cadastrarMotoristasToolStripMenuItem
            // 
            this.cadastrarMotoristasToolStripMenuItem.Name = "cadastrarMotoristasToolStripMenuItem";
            this.cadastrarMotoristasToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.cadastrarMotoristasToolStripMenuItem.Text = "Cadastrar Motoristas";
            this.cadastrarMotoristasToolStripMenuItem.Click += new System.EventHandler(this.cadastrarMotoristasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 571);
            this.Controls.Add(this.pbFundo);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transportadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romaneioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receberNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acompanhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularFreteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregasPendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregasRealizadasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbFundo;
        private System.Windows.Forms.ToolStripMenuItem listarNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarTodosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarRomaneioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarRotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMotoristasToolStripMenuItem;
    }
}

