using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Despesa
    {

        public string Tipo { get; set; }
        public double Valor { get; set; }
        public DateTime Vencimento { get; set; }
        public Cartao cartao { get; set; }

        public Despesa()
        {

        }
        public Despesa(string tipo, double valor, DateTime vencimento, Cartao cartao)
        {
            this.Tipo = tipo;
            this.Valor = valor;
            this.Vencimento = vencimento;
            this.cartao = cartao;
        }
        override
        public string ToString()
        {
            return $"Valor: {this.Valor} " +
                $"Vencimento: {this.Vencimento}" +
                $"Tipo: {this.Tipo}";
        }

    }
}
