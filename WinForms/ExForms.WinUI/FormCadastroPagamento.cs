using ExForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExForms.WinUI
{
    public partial class FormCadastroPagamento : Form
    {
        public FormCadastroPagamento()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
