using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o valor do produto no exterior:");
        decimal valorProduto = decimal.Parse(Console.ReadLine());

        if (valorProduto <= 0)
        {
            Console.WriteLine("Valor inválido, tente novamente mais tarde.");
            return;
        }

        Console.WriteLine("Escolha o tipo de frete (1 - Demorado, 2 - Médio, 3 - Rápido):");
        int tipoFrete = int.Parse(Console.ReadLine());

        decimal taxaImportacao = 0;
        decimal taxaFrete = 0;
        string nomeFrete = "";

        switch (tipoFrete)
        {
            case 1:
                taxaFrete = valorProduto * 0.10m;
                nomeFrete = "Frete demorado";
                break;
            case 2:
                taxaFrete = valorProduto * 0.15m;
                nomeFrete = "Frete médio";
                break;
            case 3:
                taxaFrete = valorProduto * 0.20m;
                nomeFrete = "Frete rápido";
                break;
            default:
                Console.WriteLine("Opção de frete inválida, tente novamente mais tarde.");
                return;
        }

        taxaImportacao = valorProduto * 0.60m;
        decimal valorProdutoFinal = valorProduto + taxaImportacao + taxaFrete;

        Console.WriteLine($"Você escolheu o frete: {nomeFrete}");
        Console.WriteLine($"Valor da taxa de importação: {taxaImportacao:C}");
        Console.WriteLine($"Valor do frete: {taxaFrete:C}");
        Console.WriteLine($"Valor do produto final: {valorProdutoFinal:C}");
    }
}
