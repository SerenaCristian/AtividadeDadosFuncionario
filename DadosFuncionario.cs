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
            double valorPromocao;
            string dot = new string('.', 50);

            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Sistema Dados Funcionário");
            Console.WriteLine(dot);

            Console.Write("\nDigite o Nome do Funcionário: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("\nDigite o Valor do Salário do Funcionário: ");
            funcionario.salariobruto = double.Parse(Console.ReadLine());

            Console.Write("\nO funcionário é elegível para receber aumento? Digite 1 para sim, 2 para não: ");
            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine(dot);

            if (opcao == 1)
            {
                funcionario.CalcularPromocao(out valorPromocao, out promocao);
                Console.WriteLine("\nParabéns! Você ganhou 10% de aumento.");
                Console.WriteLine($"\nSeu novo salário é de: {valorPromocao + funcionario.salariobruto} ");
                desconto = funcionario.CalculaImposto(funcionario.salariobruto, imposto);
                Console.WriteLine($"\nNome do Funcionário: {funcionario.Nome}");
                Console.WriteLine($"\nO desconto será de: {desconto}");

                Console.WriteLine($"\nSalario Liquido é de: {(valorPromocao + funcionario.salariobruto) - desconto} ");

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


