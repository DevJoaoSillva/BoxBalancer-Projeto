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
        }

        private InserindoValor objetoInserir = new InserindoValor();

        private void FrmIncluir_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            CbParcelamento.Visible = false;
            CbPagamento.Items.Add("Crédito");
            CbPagamento.Items.Add("Débito");
            CbPagamento.Items.Add("Dinheiro");
            CbPagamento.Items.Add("PIX");

            CbVendedor.Items.Add("João Pedro");
            CbVendedor.Items.Add("Thiago");
            CbVendedor.Items.Add("João Paulo");

            CbTipo.Items.Add("Entrada");
            CbTipo.Items.Add("Saída");
        }

        private void CbPagamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CbPagamento.SelectedItem.ToString() == "Crédito")
            {
                double valor = double.Parse(TxtValor.Text);
                CbParcelamento.Text = ($"1x de {valor:C}");
                label5.Visible = true;
                CbParcelamento.Visible = true;

                CbParcelamento.Items.Clear();
                CbParcelamento.Items.Add($"1x de {valor:C}");
                CbParcelamento.Items.Add($"2x de {valor / 2:C}");
                CbParcelamento.Items.Add($"3x de {valor / 3:C}");
                CbParcelamento.Items.Add($"4x de {valor / 4:C}");
                CbParcelamento.Items.Add($"5x de {valor / 5:C}");
                CbParcelamento.Items.Add($"6x de {valor / 6:C}");
            }
            else
            {
                label5.Visible = false;
                CbParcelamento.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtValor.Text))
            {
                MessageBox.Show("Insira um valor, mesmo que seja 'R$ 00,00'");
            }
            else
            {
                if (string.IsNullOrEmpty(CbVendedor.Text))
                {
                    MessageBox.Show("Selecione um vendedor para a inclusão da venda.");
                }
                else
                {
                    if (string.IsNullOrEmpty(CbTipo.Text))
                    {
                        MessageBox.Show("Descreva o tipo da movimentação");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(CbPagamento.Text))
                        {
                            MessageBox.Show("Informe a forma de pagamento.");
                        }
                        else
                        {
                            // Define os valores para a instância de InserindoValor
                           // Defina o código conforme necessário
                            objetoInserir.Vendedor_Movimentacao = CbVendedor.Text;
                            objetoInserir.TipoDeEntrada_Movimentacao = CbTipo.Text;
                            objetoInserir.Valor_Movimentacao = double.Parse(TxtValor.Text);
                            objetoInserir.FormaPagamento_Movimentacao = CbPagamento.Text;

                            // Chama o método Inserir para inserir os dados no banco de dados
                            objetoInserir.Inserir();

                            MessageBox.Show("Valor inserido com sucesso!");
                            TxtValor.Clear();
                            
                        }
                    }
                }
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
