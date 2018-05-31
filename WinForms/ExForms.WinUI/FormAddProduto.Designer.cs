namespace ExForms.WinUI
{
    partial class FormAddProduto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddQTD = new System.Windows.Forms.TextBox();
            this.txtAddProduto = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnCancelarADD = new System.Windows.Forms.Button();
            this.btnSalvarADD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelarADD);
            this.groupBox1.Controls.Add(this.btnSalvarADD);
            this.groupBox1.Controls.Add(this.txtAddQTD);
            this.groupBox1.Controls.Add(this.txtAddProduto);
            this.groupBox1.Controls.Add(this.lblQuantidade);
            this.groupBox1.Controls.Add(this.lblProduto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insira os campos abaixo";
            // 
            // txtAddQTD
            // 
            this.txtAddQTD.Location = new System.Drawing.Point(118, 58);
            this.txtAddQTD.Name = "txtAddQTD";
            this.txtAddQTD.Size = new System.Drawing.Size(60, 20);
            this.txtAddQTD.TabIndex = 3;
            // 
            // txtAddProduto
            // 
            this.txtAddProduto.Location = new System.Drawing.Point(118, 32);
            this.txtAddProduto.Name = "txtAddProduto";
            this.txtAddProduto.Size = new System.Drawing.Size(120, 20);
            this.txtAddProduto.TabIndex = 2;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(6, 55);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(86, 17);
            this.lblQuantidade.TabIndex = 1;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(6, 32);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(62, 17);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // btnCancelarADD
            // 
            this.btnCancelarADD.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnCancelarADD.Location = new System.Drawing.Point(124, 86);
            this.btnCancelarADD.Name = "btnCancelarADD";
            this.btnCancelarADD.Size = new System.Drawing.Size(60, 22);
            this.btnCancelarADD.TabIndex = 7;
            this.btnCancelarADD.Text = "Cancelar";
            this.btnCancelarADD.UseVisualStyleBackColor = true;
            // 
            // btnSalvarADD
            // 
            this.btnSalvarADD.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnSalvarADD.Location = new System.Drawing.Point(190, 86);
            this.btnSalvarADD.Name = "btnSalvarADD";
            this.btnSalvarADD.Size = new System.Drawing.Size(48, 22);
            this.btnSalvarADD.TabIndex = 6;
            this.btnSalvarADD.Text = "Salvar";
            this.btnSalvarADD.UseVisualStyleBackColor = true;
            // 
            // FormAddProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 143);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAddProduto";
            this.Text = "FormAddProduto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtAddQTD;
        private System.Windows.Forms.TextBox txtAddProduto;
        private System.Windows.Forms.Button btnCancelarADD;
        private System.Windows.Forms.Button btnSalvarADD;
    }
}