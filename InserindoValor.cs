using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BETA___BOXBALANCER
{
    internal class InserindoValor
    {
        private Conexao objetoConexao = new Conexao();
        private int codigo_Movimentacao;
        private string tipoDeEntrada_Movimentacao;
        private double valor_Movimentacao;
        private string formaPagamento_Movimentacao;
        private string vendedor_Movimentacao;

        public int Codigo_Movimentacao { get => codigo_Movimentacao; set => codigo_Movimentacao = value; }
        public string TipoDeEntrada_Movimentacao { get => tipoDeEntrada_Movimentacao; set => tipoDeEntrada_Movimentacao = value; }
        public double Valor_Movimentacao { get => valor_Movimentacao; set => valor_Movimentacao = value; }
        public string FormaPagamento_Movimentacao { get => formaPagamento_Movimentacao; set => formaPagamento_Movimentacao = value; }
        public string Vendedor_Movimentacao { get => vendedor_Movimentacao; set => vendedor_Movimentacao = value; }

        public void Inserir()
        {
            string sql = "";
            sql += $"Insert into Movimentacao (Vendedor_Movimentacao, TipoDeEntrada_Movimentacao, Valor_Movimentacao, FormaPagamento_Movimentacao)" +
                $"values ('{Vendedor_Movimentacao}','{TipoDeEntrada_Movimentacao}', {Valor_Movimentacao.ToString().Replace(',', '.')}, '{FormaPagamento_Movimentacao}' )";
            objetoConexao.Conectar();
            objetoConexao.Executar(sql);
            objetoConexao.Desconectar();
        }
    }
}
