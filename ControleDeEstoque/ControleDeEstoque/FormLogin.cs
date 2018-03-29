using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if ((txtUsuario.Text == "cantina") && (txtSenha.Text == "1234"))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ops, digita certo ai bro!");
            }


            this.DialogResult = DialogResult.OK;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
