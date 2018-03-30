namespace ControleDeEstoque
{
    partial class FormAddP
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar01 = new System.Windows.Forms.Button();
            this.lblTitulo03 = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.txtCatP = new System.Windows.Forms.TextBox();
            this.txtDescP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Descrição:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(12, 94);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(82, 20);
            this.lblCategoria.TabIndex = 21;
            this.lblCategoria.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome:";
            // 
            // btnVoltar01
            // 
            this.btnVoltar01.Location = new System.Drawing.Point(234, 202);
            this.btnVoltar01.Name = "btnVoltar01";
            this.btnVoltar01.Size = new System.Drawing.Size(45, 27);
            this.btnVoltar01.TabIndex = 24;
            this.btnVoltar01.Text = "Voltar";
            this.btnVoltar01.UseVisualStyleBackColor = true;
            this.btnVoltar01.Click += new System.EventHandler(this.btnVoltar01_Click);
            // 
            // lblTitulo03
            // 
            this.lblTitulo03.AutoSize = true;
            this.lblTitulo03.Font = new System.Drawing.Font("Stylus BT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo03.Location = new System.Drawing.Point(44, 20);
            this.lblTitulo03.Name = "lblTitulo03";
            this.lblTitulo03.Size = new System.Drawing.Size(218, 30);
            this.lblTitulo03.TabIndex = 25;
            this.lblTitulo03.Text = "Adicionar Produto";
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(121, 202);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(55, 27);
            this.btnApagar.TabIndex = 26;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(182, 202);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(46, 27);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(113, 68);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(166, 20);
            this.txtNomeP.TabIndex = 28;
            // 
            // txtCatP
            // 
            this.txtCatP.Location = new System.Drawing.Point(113, 96);
            this.txtCatP.Name = "txtCatP";
            this.txtCatP.Size = new System.Drawing.Size(166, 20);
            this.txtCatP.TabIndex = 29;
            // 
            // txtDescP
            // 
            this.txtDescP.Location = new System.Drawing.Point(113, 122);
            this.txtDescP.Multiline = true;
            this.txtDescP.Name = "txtDescP";
            this.txtDescP.Size = new System.Drawing.Size(166, 74);
            this.txtDescP.TabIndex = 30;
            // 
            // FormAddP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(306, 245);
            this.Controls.Add(this.txtDescP);
            this.Controls.Add(this.txtCatP);
            this.Controls.Add(this.txtNomeP);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.lblTitulo03);
            this.Controls.Add(this.btnVoltar01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormAddP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar01;
        private System.Windows.Forms.Label lblTitulo03;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNomeP;
        private System.Windows.Forms.TextBox txtCatP;
        private System.Windows.Forms.TextBox txtDescP;
    }
}