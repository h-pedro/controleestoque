namespace ControleDeEstoque
{
    partial class s
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(s));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVisualizarEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInserirProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlterarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcluirProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVendasaVista = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVendasFiado = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelatorioVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visãoSemestralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.custosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVisualizarVendasaVista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVisualizarEstoque,
            this.clienteToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.cadastrosToolStripMenuItem.Text = "Estoque";
            this.cadastrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
            // 
            // btnVisualizarEstoque
            // 
            this.btnVisualizarEstoque.Name = "btnVisualizarEstoque";
            this.btnVisualizarEstoque.Size = new System.Drawing.Size(168, 22);
            this.btnVisualizarEstoque.Text = "Visualizar Estoque";
            this.btnVisualizarEstoque.Click += new System.EventHandler(this.btnVisualizarEstoque_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserirProduto,
            this.btnAlterarProduto,
            this.btnExcluirProduto});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.clienteToolStripMenuItem.Text = "Editar";
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Size = new System.Drawing.Size(152, 22);
            this.btnInserirProduto.Text = "Inserir";
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(152, 22);
            this.btnAlterarProduto.Text = "Alterar";
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(152, 22);
            this.btnExcluirProduto.Text = "Excluir";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.usuárioToolStripMenuItem.Text = "Histórico";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeEstoqueToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.visãoSemestralToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.estoqueToolStripMenuItem.Text = "Financeiro";
            // 
            // consultaDeEstoqueToolStripMenuItem
            // 
            this.consultaDeEstoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVendasaVista,
            this.btnVendasFiado,
            this.btnRelatorioVendas});
            this.consultaDeEstoqueToolStripMenuItem.Name = "consultaDeEstoqueToolStripMenuItem";
            this.consultaDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.consultaDeEstoqueToolStripMenuItem.Text = "Vendas";
            this.consultaDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.consultaDeEstoqueToolStripMenuItem_Click);
            // 
            // btnVendasaVista
            // 
            this.btnVendasaVista.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVisualizarVendasaVista});
            this.btnVendasaVista.Name = "btnVendasaVista";
            this.btnVendasaVista.Size = new System.Drawing.Size(162, 22);
            this.btnVendasaVista.Text = "Á vista";
            // 
            // btnVendasFiado
            // 
            this.btnVendasFiado.Name = "btnVendasFiado";
            this.btnVendasFiado.Size = new System.Drawing.Size(162, 22);
            this.btnVendasFiado.Text = "Fiado";
            // 
            // btnRelatorioVendas
            // 
            this.btnRelatorioVendas.Name = "btnRelatorioVendas";
            this.btnRelatorioVendas.Size = new System.Drawing.Size(162, 22);
            this.btnRelatorioVendas.Text = "Relatório Mensal";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gastosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.saldoToolStripMenuItem});
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // gastosToolStripMenuItem
            // 
            this.gastosToolStripMenuItem.Name = "gastosToolStripMenuItem";
            this.gastosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gastosToolStripMenuItem.Text = "Custos";
            this.gastosToolStripMenuItem.Click += new System.EventHandler(this.gastosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // saldoToolStripMenuItem
            // 
            this.saldoToolStripMenuItem.Name = "saldoToolStripMenuItem";
            this.saldoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saldoToolStripMenuItem.Text = "Saldo";
            // 
            // visãoSemestralToolStripMenuItem
            // 
            this.visãoSemestralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem1,
            this.custosToolStripMenuItem});
            this.visãoSemestralToolStripMenuItem.Name = "visãoSemestralToolStripMenuItem";
            this.visãoSemestralToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.visãoSemestralToolStripMenuItem.Text = "Visão Semestral";
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            // 
            // custosToolStripMenuItem
            // 
            this.custosToolStripMenuItem.Name = "custosToolStripMenuItem";
            this.custosToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.custosToolStripMenuItem.Text = "Custos";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeVendasToolStripMenuItem,
            this.relatórioDeClientesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.relatóriosToolStripMenuItem.Text = "Usuário";
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            this.relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            this.relatórioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.relatórioDeVendasToolStripMenuItem.Text = "Gerenciar Perfil";
            // 
            // relatórioDeClientesToolStripMenuItem
            // 
            this.relatórioDeClientesToolStripMenuItem.Name = "relatórioDeClientesToolStripMenuItem";
            this.relatórioDeClientesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.relatórioDeClientesToolStripMenuItem.Text = "Trocar Usuário";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // btnVisualizarVendasaVista
            // 
            this.btnVisualizarVendasaVista.Name = "btnVisualizarVendasaVista";
            this.btnVisualizarVendasaVista.Size = new System.Drawing.Size(152, 22);
            this.btnVisualizarVendasaVista.Text = "Vizualizar";
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(780, 399);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "s";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantina dos Jovens";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnVisualizarEstoque;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnInserirProduto;
        private System.Windows.Forms.ToolStripMenuItem btnAlterarProduto;
        private System.Windows.Forms.ToolStripMenuItem btnExcluirProduto;
        private System.Windows.Forms.ToolStripMenuItem btnVendasaVista;
        private System.Windows.Forms.ToolStripMenuItem btnVendasFiado;
        private System.Windows.Forms.ToolStripMenuItem btnRelatorioVendas;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visãoSemestralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem custosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnVisualizarVendasaVista;
    }
}