using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
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
            }
            else
            {
                if (string.IsNullOrEmpty(CbFuncionario.Text))
                {
                    MessageBox.Show("Selecione um funcionário para a abertura do caixa.");
                }
                else
                {
                    if (double.TryParse(TxtSaldoInicial.Text, out double saldoInicial))
                    {
                        pictureBox1.Image = Properties.Resources.caixaaberto;
                        LblCaixa.Text = ("ABERTO");
                        TxtBSaldoInicialResumo.Text = saldoInicial.ToString("C2");
                        LblData.Text = DateTime.Now.ToLongDateString();
                        PnlMovimentacoes.Enabled = true;
                        PnlResumo.Enabled = true;
                        CbFuncionario.Enabled = false;
                        TxtSaldoInicial.Enabled = false;
                        BtnAbrirCaixa.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("O valor inserido não é válido. Insira um número válido.");
                    }
                }
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
            CbFuncionario.Items.Add("João Pedro");
            CbFuncionario.Items.Add("Thiago");
            CbFuncionario.Items.Add("João Paulo");
            CbFuncionario.Items.Add("Leonardo");
        }
    }
}
