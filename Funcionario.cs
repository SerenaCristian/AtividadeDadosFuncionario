using System;

namespace DadosFuncionario
{
    public class Funcionario
    {
        public string Nome;
        public double salariobruto;
        public double imposto = 0.34;
        public double desconto;
        public double salarioliquido;
        public double promocao;
        public double valorimposto;
        public double valorPromocao;

        public double CalculaImposto(double salariobruto, double imposto)
        {
            double valorimposto = salariobruto * imposto;
            return valorimposto;
        }

        public void CalcularPromocao(out double valorPromocao, out double promocao)
        {
            promocao = 0.10;
            valorPromocao = salariobruto * promocao;
        }
    }
}
