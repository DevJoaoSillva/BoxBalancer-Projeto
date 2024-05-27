using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BETA___BOXBALANCER
{
    public partial class FrmIncluir : Form
    {
        public FrmIncluir()
        {
            InitializeComponent();
            label5.Visible = false;
            CbParcelamento.Visible = false;
            CbPagamento.Items.Add("Crédito");
            CbPagamento.Items.Add("Débito");
            CbPagamento.Items.Add("Dinheiro");
            CbPagamento.Items.Add("PIX");
        }

        private void CbPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
