namespace ExForms.WinUI
{
    partial class FormCadastroPagamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.btnCancelarr = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNome_Pagamento = new System.Windows.Forms.TextBox();
            this.lblTipoPagamento = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textDescricao);
            this.groupBox1.Controls.Add(this.btnCancelarr);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.txtNome_Pagamento);
            this.groupBox1.Controls.Add(this.lblTipoPagamento);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro  de Pagamento";
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(25, 87);
            this.textDescricao.Multiline = true;
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(213, 117);
            this.textDescricao.TabIndex = 10;
            // 
            // btnCancelarr
            // 
            this.btnCancelarr.Location = new System.Drawing.Point(163, 210);
            this.btnCancelarr.Name = "btnCancelarr";
            this.btnCancelarr.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarr.TabIndex = 9;
            this.btnCancelarr.Text = "Cancelar";
            this.btnCancelarr.UseVisualStyleBackColor = true;
            this.btnCancelarr.Click += new System.EventHandler(this.btnCancelarr_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(82, 210);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(22, 71);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 7;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtNome_Pagamento
            // 
            this.txtNome_Pagamento.Location = new System.Drawing.Point(25, 35);
            this.txtNome_Pagamento.Name = "txtNome_Pagamento";
            this.txtNome_Pagamento.Size = new System.Drawing.Size(213, 20);
            this.txtNome_Pagamento.TabIndex = 6;
            // 
            // lblTipoPagamento
            // 
            this.lblTipoPagamento.AutoSize = true;
            this.lblTipoPagamento.Location = new System.Drawing.Point(22, 19);
            this.lblTipoPagamento.Name = "lblTipoPagamento";
            this.lblTipoPagamento.Size = new System.Drawing.Size(88, 13);
            this.lblTipoPagamento.TabIndex = 5;
            this.lblTipoPagamento.Text = "Tipo Pagamento:";
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // FormCadastroPagamento
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCadastroPagamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvarCPagamento;
        private System.Windows.Forms.TextBox txtTipoPagamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelarr;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNome_Pagamento;
        private System.Windows.Forms.Label lblTipoPagamento;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.ErrorProvider error;
    }
}