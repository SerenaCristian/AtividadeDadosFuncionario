using System;

namespace DadosFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salariobruto;
            double imposto = 0.34;
            double desconto;
            double salarioliquido;
            double promocao;
            string dot = new string('.', 50);

            Console.WriteLine("Sistema Dados Funcionário");
            Console.WriteLine(dot);

            Console.Write("\nDigite o Nome do Funcionário: ");
            nome = Console.ReadLine();

            Console.Write("\nDigite o Valor do Salário do Funcionário: ");
            salariobruto = double.Parse(Console.ReadLine());

            Console.Write("\nO funcionário é elegível para receber aumento? Digite 1 para sim, 2 para não: ");
            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine(dot);

            // Calcula o desconto dos impostos no salário
            desconto = salariobruto * imposto;
            salarioliquido = salariobruto - desconto;

            // Aqui será implementada a lógica do aumento
            promocao = 0.10;
            double aumento = salariobruto * promocao;

            if (opcao == 1)
            {
                Console.WriteLine("\nParabéns! Você ganhou 10% de aumento.");
                Console.WriteLine($"\nSeu novo salário é de: {aumento + salariobruto}");
                Console.WriteLine($"\nNome do Funcionário: {nome}");
                Console.WriteLine($"\nO desconto será de: {(desconto + aumento).ToString("F2")}");
                Console.WriteLine($"\nO salário líquido é de: {(salarioliquido + aumento).ToString("F2")}");

                Console.WriteLine("\n* ATENÇÃO: TOTAL DE DESCONTO É 34%");
                Console.WriteLine(dot);
            }
            else
            {
                Console.WriteLine("Funcionário não é elegível para a promoção.");
            }
        }
    }
}

