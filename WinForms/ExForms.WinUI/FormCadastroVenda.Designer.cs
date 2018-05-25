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
            this.gpbVendas = new System.Windows.Forms.GroupBox();
            this.btnCancelarCadastroVenda = new System.Windows.Forms.Button();
            this.btnSalvarCadastroVenda = new System.Windows.Forms.Button();
            this.txtIensCadastroVenda = new System.Windows.Forms.TextBox();
            this.lblItensCdastroVenda = new System.Windows.Forms.Label();
            this.cboPagamento = new System.Windows.Forms.ComboBox();
            this.lblTipoPagamentoCadastroVenda = new System.Windows.Forms.Label();
            this.txtClienteCadastroVenda = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtDataCadastroVenda = new System.Windows.Forms.DateTimePicker();
            this.lblCadastroVenda = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbVendas
            // 
            this.gpbVendas.Controls.Add(this.btnCancelarCadastroVenda);
            this.gpbVendas.Controls.Add(this.btnSalvarCadastroVenda);
            this.gpbVendas.Controls.Add(this.txtIensCadastroVenda);
            this.gpbVendas.Controls.Add(this.lblItensCdastroVenda);
            this.gpbVendas.Controls.Add(this.cboPagamento);
            this.gpbVendas.Controls.Add(this.lblTipoPagamentoCadastroVenda);
            this.gpbVendas.Controls.Add(this.txtClienteCadastroVenda);
            this.gpbVendas.Controls.Add(this.lblCliente);
            this.gpbVendas.Controls.Add(this.txtDataCadastroVenda);
            this.gpbVendas.Controls.Add(this.lblCadastroVenda);
            this.gpbVendas.Location = new System.Drawing.Point(12, 12);
            this.gpbVendas.Name = "gpbVendas";
            this.gpbVendas.Size = new System.Drawing.Size(366, 318);
            this.gpbVendas.TabIndex = 0;
            this.gpbVendas.TabStop = false;
            this.gpbVendas.Text = "Cadastro de vendas";
            // 
            // btnCancelarCadastroVenda
            // 
            this.btnCancelarCadastroVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCadastroVenda.Location = new System.Drawing.Point(256, 283);
            this.btnCancelarCadastroVenda.Name = "btnCancelarCadastroVenda";
            this.btnCancelarCadastroVenda.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadastroVenda.TabIndex = 12;
            this.btnCancelarCadastroVenda.Text = "Cancelar";
            this.btnCancelarCadastroVenda.UseVisualStyleBackColor = true;
            // 
            // btnSalvarCadastroVenda
            // 
            this.btnSalvarCadastroVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarCadastroVenda.Location = new System.Drawing.Point(170, 283);
            this.btnSalvarCadastroVenda.Name = "btnSalvarCadastroVenda";
            this.btnSalvarCadastroVenda.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCadastroVenda.TabIndex = 11;
            this.btnSalvarCadastroVenda.Text = "Salvar";
            this.btnSalvarCadastroVenda.UseVisualStyleBackColor = true;
            this.btnSalvarCadastroVenda.Click += new System.EventHandler(this.btnSalvarCadastroVenda_Click);
            // 
            // txtIensCadastroVenda
            // 
            this.txtIensCadastroVenda.Location = new System.Drawing.Point(29, 201);
            this.txtIensCadastroVenda.Multiline = true;
            this.txtIensCadastroVenda.Name = "txtIensCadastroVenda";
            this.txtIensCadastroVenda.Size = new System.Drawing.Size(302, 76);
            this.txtIensCadastroVenda.TabIndex = 8;
            // 
            // lblItensCdastroVenda
            // 
            this.lblItensCdastroVenda.AutoSize = true;
            this.lblItensCdastroVenda.Location = new System.Drawing.Point(26, 185);
            this.lblItensCdastroVenda.Name = "lblItensCdastroVenda";
            this.lblItensCdastroVenda.Size = new System.Drawing.Size(89, 13);
            this.lblItensCdastroVenda.TabIndex = 7;
            this.lblItensCdastroVenda.Text = "Itens Comprados:";
            // 
            // cboPagamento
            // 
            this.cboPagamento.FormattingEnabled = true;
            this.cboPagamento.Location = new System.Drawing.Point(29, 150);
            this.cboPagamento.Name = "cboPagamento";
            this.cboPagamento.Size = new System.Drawing.Size(302, 21);
            this.cboPagamento.TabIndex = 6;
            // 
            // lblTipoPagamentoCadastroVenda
            // 
            this.lblTipoPagamentoCadastroVenda.AutoSize = true;
            this.lblTipoPagamentoCadastroVenda.Location = new System.Drawing.Point(26, 134);
            this.lblTipoPagamentoCadastroVenda.Name = "lblTipoPagamentoCadastroVenda";
            this.lblTipoPagamentoCadastroVenda.Size = new System.Drawing.Size(103, 13);
            this.lblTipoPagamentoCadastroVenda.TabIndex = 5;
            this.lblTipoPagamentoCadastroVenda.Text = "Tipo de Pagamento:";
            // 
            // txtClienteCadastroVenda
            // 
            this.txtClienteCadastroVenda.Location = new System.Drawing.Point(29, 99);
            this.txtClienteCadastroVenda.Name = "txtClienteCadastroVenda";
            this.txtClienteCadastroVenda.Size = new System.Drawing.Size(302, 20);
            this.txtClienteCadastroVenda.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(26, 82);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtDataCadastroVenda
            // 
            this.txtDataCadastroVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataCadastroVenda.Location = new System.Drawing.Point(29, 48);
            this.txtDataCadastroVenda.Name = "txtDataCadastroVenda";
            this.txtDataCadastroVenda.Size = new System.Drawing.Size(302, 20);
            this.txtDataCadastroVenda.TabIndex = 2;
            // 
            // lblCadastroVenda
            // 
            this.lblCadastroVenda.AutoSize = true;
            this.lblCadastroVenda.Location = new System.Drawing.Point(26, 32);
            this.lblCadastroVenda.Name = "lblCadastroVenda";
            this.lblCadastroVenda.Size = new System.Drawing.Size(33, 13);
            this.lblCadastroVenda.TabIndex = 1;
            this.lblCadastroVenda.Text = "Data:";
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
            this.ClientSize = new System.Drawing.Size(395, 343);
            this.Controls.Add(this.gpbVendas);
            this.Name = "FormCadastroVenda";
            this.Text = "FormCadastroVenda";
            this.Load += new System.EventHandler(this.FormCadastroVenda_Load);
            this.gpbVendas.ResumeLayout(false);
            this.gpbVendas.PerformLayout();
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
        private System.Windows.Forms.TextBox txtIensCadastroVenda;
        private System.Windows.Forms.Label lblItensCdastroVenda;
        private System.Windows.Forms.ComboBox cboPagamento;
        private System.Windows.Forms.Button btnCancelarCadastroVenda;
        private System.Windows.Forms.Button btnSalvarCadastroVenda;
        private System.Windows.Forms.ErrorProvider error;
    }
}