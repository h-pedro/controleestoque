﻿using ExForms.DataAccess;
using ExForms.Models;
using System;
using System.Windows.Forms;

namespace ExForms.WinUI
{
    public partial class FormLogin : Form
    {
        public Usuario Usuario { get; set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            FazerLogin();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FazerLogin();
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void FazerLogin()
        {
            if (!ValidarCampos())
                return;

            var obj = new Usuario()
            {
                Login = txtLogin.Text,
                Senha = txtSenha.Text
            };

            var result = new UsuarioDAO().Logar(obj);
            if (result != null)
            {
                this.Usuario = result;
                DialogResult = DialogResult.OK;
            }
            else
            {
                txtSenha.Text = string.Empty;
                MessageBox.Show("Login ou senha inválido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Focus();
            }
        }

        private bool ValidarCampos()
        {
            error.Clear();
            var aux = true;
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                aux = false;
                error.SetError(txtLogin, "Campo obrigatório!");
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                aux = false;
                error.SetError(txtSenha, "Campo obrigatório!");
            }
            return aux;
        }
    }
}
