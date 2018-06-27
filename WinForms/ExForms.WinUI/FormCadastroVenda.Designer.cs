namespace ExForms.WinUI
{
    partial class FormCadastroVenda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroVenda));
            this.gpbVendas = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.mnuAcoes = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.cboPagamento = new System.Windows.Forms.ComboBox();
            this.lblTipoPagamentoCadastroVenda = new System.Windows.Forms.Label();
            this.txtClienteCadastroVenda = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtDataCadastroVenda = new System.Windows.Forms.DateTimePicker();
            this.lblCadastroVenda = new System.Windows.Forms.Label();
            this.btnCancelarCadastroVenda = new System.Windows.Forms.Button();
            this.btnSalvarCadastroVenda = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbVendas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.mnuAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbVendas
            // 
            this.gpbVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbVendas.Controls.Add(this.panel1);
            this.gpbVendas.Controls.Add(this.cboPagamento);
            this.gpbVendas.Controls.Add(this.lblTipoPagamentoCadastroVenda);
            this.gpbVendas.Controls.Add(this.txtClienteCadastroVenda);
            this.gpbVendas.Controls.Add(this.lblCliente);
            this.gpbVendas.Controls.Add(this.txtDataCadastroVenda);
            this.gpbVendas.Controls.Add(this.lblCadastroVenda);
            this.gpbVendas.Location = new System.Drawing.Point(12, 12);
            this.gpbVendas.Name = "gpbVendas";
            this.gpbVendas.Size = new System.Drawing.Size(446, 405);
            this.gpbVendas.TabIndex = 0;
            this.gpbVendas.TabStop = false;
            this.gpbVendas.Text = "Cadastro de Vendas";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gridView);
            this.panel1.Controls.Add(this.mnuAcoes);
            this.panel1.Location = new System.Drawing.Point(19, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 252);
            this.panel1.TabIndex = 14;
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.AllowUserToDeleteRows = false;
            this.gridView.AllowUserToResizeRows = false;
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView.Location = new System.Drawing.Point(0, 25);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(406, 225);
            this.gridView.TabIndex = 1;
            // 
            // mnuAcoes
            // 
            this.mnuAcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnExcluir});
            this.mnuAcoes.Location = new System.Drawing.Point(0, 0);
            this.mnuAcoes.Name = "mnuAcoes";
            this.mnuAcoes.Size = new System.Drawing.Size(406, 25);
            this.mnuAcoes.TabIndex = 0;
            this.mnuAcoes.Text = "Ações";
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(23, 22);
            this.btnNovo.Text = "Novo";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cboPagamento
            // 
            this.cboPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPagamento.FormattingEnabled = true;
            this.cboPagamento.Location = new System.Drawing.Point(149, 44);
            this.cboPagamento.Name = "cboPagamento";
            this.cboPagamento.Size = new System.Drawing.Size(278, 21);
            this.cboPagamento.TabIndex = 6;
            // 
            // lblTipoPagamentoCadastroVenda
            // 
            this.lblTipoPagamentoCadastroVenda.AutoSize = true;
            this.lblTipoPagamentoCadastroVenda.Location = new System.Drawing.Point(149, 28);
            this.lblTipoPagamentoCadastroVenda.Name = "lblTipoPagamentoCadastroVenda";
            this.lblTipoPagamentoCadastroVenda.Size = new System.Drawing.Size(103, 13);
            this.lblTipoPagamentoCadastroVenda.TabIndex = 5;
            this.lblTipoPagamentoCadastroVenda.Text = "Tipo de Pagamento:";
            // 
            // txtClienteCadastroVenda
            // 
            this.txtClienteCadastroVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClienteCadastroVenda.Location = new System.Drawing.Point(19, 92);
            this.txtClienteCadastroVenda.Name = "txtClienteCadastroVenda";
            this.txtClienteCadastroVenda.Size = new System.Drawing.Size(408, 20);
            this.txtClienteCadastroVenda.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(19, 75);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtDataCadastroVenda
            // 
            this.txtDataCadastroVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataCadastroVenda.Location = new System.Drawing.Point(19, 44);
            this.txtDataCadastroVenda.Name = "txtDataCadastroVenda";
            this.txtDataCadastroVenda.Size = new System.Drawing.Size(120, 20);
            this.txtDataCadastroVenda.TabIndex = 2;
            // 
            // lblCadastroVenda
            // 
            this.lblCadastroVenda.AutoSize = true;
            this.lblCadastroVenda.Location = new System.Drawing.Point(19, 28);
            this.lblCadastroVenda.Name = "lblCadastroVenda";
            this.lblCadastroVenda.Size = new System.Drawing.Size(33, 13);
            this.lblCadastroVenda.TabIndex = 1;
            this.lblCadastroVenda.Text = "Data:";
            // 
            // btnCancelarCadastroVenda
            // 
            this.btnCancelarCadastroVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCadastroVenda.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarCadastroVenda.Location = new System.Drawing.Point(383, 425);
            this.btnCancelarCadastroVenda.Name = "btnCancelarCadastroVenda";
            this.btnCancelarCadastroVenda.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadastroVenda.TabIndex = 12;
            this.btnCancelarCadastroVenda.Text = "Cancelar";
            this.btnCancelarCadastroVenda.UseVisualStyleBackColor = true;
            this.btnCancelarCadastroVenda.Click += new System.EventHandler(this.btnCancelarCadastroVenda_Click);
            // 
            // btnSalvarCadastroVenda
            // 
            this.btnSalvarCadastroVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarCadastroVenda.Location = new System.Drawing.Point(297, 425);
            this.btnSalvarCadastroVenda.Name = "btnSalvarCadastroVenda";
            this.btnSalvarCadastroVenda.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCadastroVenda.TabIndex = 11;
            this.btnSalvarCadastroVenda.Text = "Salvar";
            this.btnSalvarCadastroVenda.UseVisualStyleBackColor = true;
            this.btnSalvarCadastroVenda.Click += new System.EventHandler(this.btnSalvarCadastroVenda_Click);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // FormCadastroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarCadastroVenda;
            this.ClientSize = new System.Drawing.Size(469, 461);
            this.Controls.Add(this.gpbVendas);
            this.Controls.Add(this.btnCancelarCadastroVenda);
            this.Controls.Add(this.btnSalvarCadastroVenda);
            this.MinimumSize = new System.Drawing.Size(485, 500);
            this.Name = "FormCadastroVenda";
            this.Text = "Cadastro de Venda";
            this.Load += new System.EventHandler(this.FormCadastroVenda_Load);
            this.gpbVendas.ResumeLayout(false);
            this.gpbVendas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.mnuAcoes.ResumeLayout(false);
            this.mnuAcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbVendas;
        private System.Windows.Forms.Label lblCadastroVenda;
        private System.Windows.Forms.DateTimePicker txtDataCadastroVenda;
        private System.Windows.Forms.Label lblTipoPagamentoCadastroVenda;
        private System.Windows.Forms.TextBox txtClienteCadastroVenda;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboPagamento;
        private System.Windows.Forms.Button btnCancelarCadastroVenda;
        private System.Windows.Forms.Button btnSalvarCadastroVenda;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.ToolStrip mnuAcoes;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnExcluir;
    }
}