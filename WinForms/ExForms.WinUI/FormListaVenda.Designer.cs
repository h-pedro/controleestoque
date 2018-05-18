namespace ExForms.WinUI
{
    partial class FormListaVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridViewVenda = new System.Windows.Forms.DataGridView();
            this.colunMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuAcoes = new System.Windows.Forms.ToolStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.txtBusca = new System.Windows.Forms.ToolStripTextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVenda)).BeginInit();
            this.mnuAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gridViewVenda);
            this.panel1.Controls.Add(this.mnuAcoes);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 408);
            this.panel1.TabIndex = 4;
            // 
            // gridViewVenda
            // 
            this.gridViewVenda.AllowUserToAddRows = false;
            this.gridViewVenda.AllowUserToDeleteRows = false;
            this.gridViewVenda.AllowUserToResizeRows = false;
            this.gridViewVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunMedida,
            this.colNome,
            this.colCategoria,
            this.colPreco,
            this.Medida,
            this.Valor});
            this.gridViewVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewVenda.Location = new System.Drawing.Point(0, 25);
            this.gridViewVenda.MultiSelect = false;
            this.gridViewVenda.Name = "gridViewVenda";
            this.gridViewVenda.RowHeadersVisible = false;
            this.gridViewVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewVenda.Size = new System.Drawing.Size(741, 381);
            this.gridViewVenda.TabIndex = 1;
            // 
            // colunMedida
            // 
            this.colunMedida.DataPropertyName = "Id";
            this.colunMedida.HeaderText = "ID";
            this.colunMedida.Name = "colunMedida";
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Cliente";
            this.colNome.Name = "colNome";
            // 
            // colCategoria
            // 
            this.colCategoria.DataPropertyName = "NomeCategoria";
            this.colCategoria.HeaderText = "Data";
            this.colCategoria.Name = "colCategoria";
            // 
            // colPreco
            // 
            this.colPreco.DataPropertyName = "Preco";
            this.colPreco.HeaderText = "Tipo de Pagamento";
            this.colPreco.Name = "colPreco";
            // 
            // Medida
            // 
            this.Medida.DataPropertyName = "SiglaUM";
            this.Medida.HeaderText = "Itens";
            this.Medida.Name = "Medida";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // mnuAcoes
            // 
            this.mnuAcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnEditar,
            this.btnExcluir,
            this.btnBuscar,
            this.txtBusca});
            this.mnuAcoes.Location = new System.Drawing.Point(0, 0);
            this.mnuAcoes.Name = "mnuAcoes";
            this.mnuAcoes.Size = new System.Drawing.Size(741, 25);
            this.mnuAcoes.TabIndex = 0;
            this.mnuAcoes.Text = "toolStrip1";
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
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "Editar";
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.Text = "Buscar";
            // 
            // txtBusca
            // 
            this.txtBusca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(150, 25);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(672, 427);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // FormListaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFechar);
            this.Name = "FormListaVenda";
            this.Text = "FormListVenda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewVenda)).EndInit();
            this.mnuAcoes.ResumeLayout(false);
            this.mnuAcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridViewVenda;
        private System.Windows.Forms.ToolStrip mnuAcoes;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripTextBox txtBusca;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}