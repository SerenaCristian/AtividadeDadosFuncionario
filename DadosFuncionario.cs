using System;

namespace DadosFuncionario
{
    class DadosFuncionario
    {
        static void Main(string[] args)
        {
            string nome;
            double salariobruto;
            double imposto = 0.34;
            double desconto;
            double salarioliquido;
            string dot = new string('.', 42);



            Console.WriteLine("Sistema Dados Funcionário");
            Console.WriteLine(dot);

            Console.Write("\n Digite o Nome do Funcionário: ");
            nome = Console.ReadLine();

            Console.Write("\n Digite o Valor do Salário Funcionário: ");
            salariobruto = double.Parse(Console.ReadLine());
            

            // Calcula o desconto dos impostos no salario

            desconto = (salariobruto * imposto);

            salarioliquido = salariobruto - desconto;
            Console.WriteLine(dot);

            Console.WriteLine($" Nome do Fucionário: {nome}");
            Console.WriteLine($" O Desconto será de: {desconto.ToString("F2")}");
            Console.WriteLine($" O Salario Liquido é de: {salarioliquido.ToString("F2")}");

            Console.WriteLine("\n* ATENÇÃO TOTAL DE DESCONTO É 34%");
            Console.WriteLine(dot);

        }
    }
}
