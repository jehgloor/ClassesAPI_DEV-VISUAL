using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cartao
    {

        public string NumeroCartao { get; set; }
        public string CodigoSeguranca { get; set; }
        public string ValidadeCartao { get; set; }

        public Cartao()
        {
        }

        public Cartao(string NumeroCartao, string CodigoSeguranca, string ValidadeCartao)
        {
            this.NumeroCartao = NumeroCartao;
            this.CodigoSeguranca = CodigoSeguranca;
            this.ValidadeCartao = ValidadeCartao;
        }

        override
        public string ToString()
        {
            return $"Numero do Cartão: {this.NumeroCartao} " +
                $"Codigo de Segurança: {this.CodigoSeguranca} " +
                $"Validade do Cartão: {this.ValidadeCartao}";
        }
    }
}
