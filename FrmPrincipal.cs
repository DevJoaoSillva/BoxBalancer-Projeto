using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BETA___BOXBALANCER
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnAbrirCaixa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSaldoInicial.Text))
            {
                MessageBox.Show("Insira um valor inicial, mesmo que seja 'R$ 00,00'");
                return;
            }

            if (string.IsNullOrEmpty(cbUsuario.Text))
            {
                MessageBox.Show("Selecione um funcionário para a abertura do caixa.");
                return;
            }

            if (double.TryParse(TxtSaldoInicial.Text, out double saldoInicial))
            {
                pictureBox1.Image = Properties.Resources.caixaaberto;
                LblCaixa.Text = "ABERTO";
                TxtBSaldoInicialResumo.Text = saldoInicial.ToString("C2");
                LblData.Text = DateTime.Now.ToLongDateString();
                PnlMovimentacoes.Enabled = true;
                PnlResumo.Enabled = true;
                cbUsuario.Enabled = false;
                TxtSaldoInicial.Enabled = false;
                BtnAbrirCaixa.Enabled = false;
            }
            else
            {
                MessageBox.Show("O valor inserido não é válido. Insira um número válido.");
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            FrmIncluir incluir = new FrmIncluir();
            incluir.ShowDialog();
        }

        private void BtnExluir_Click(object sender, EventArgs e)
        {
            FrmExcluir excluir = new FrmExcluir();
            excluir.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            PnlMovimentacoes.Enabled = false;
            PnlResumo.Enabled = false;
            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            List<string> usuarios = ObterUsuariosDoBancoDeDados();
            foreach (var usuario in usuarios)
            {
                cbUsuario.Items.Add(usuario);
            }
        }

        private List<string> ObterUsuariosDoBancoDeDados()
        {
            return new List<string> { "João Pedro", "Thiago", "João Paulo" };
        }
    }
}
