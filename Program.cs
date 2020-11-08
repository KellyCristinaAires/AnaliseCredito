using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            int parcela;
            decimal valor,valorParcela, valorMaximoParcela, rendaMensal;
            bool valorValido, parcelasValido, rendaMensalValido;

            Console.Write ("Digite o Valor Desejado: ");
            valorValido = Decimal.TryParse (Console.ReadLine (), out valor);

            if (!valorValido)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Você digitou um numero invalido: ");
                Console.WriteLine ("Pressione ENTER para sair,e execute o programa novamente");
                Console.ReadKey();
                Console.ResetColor();
                Environment.Exit(-1);
            }

            Console.Write("Digite a Quantidade de Parcelas Desejadas: ");
            parcelasValido = int.TryParse(Console.ReadLine(), out parcela);
              
            if (!parcelasValido)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Você digitou um numero invalido: ");
                Console.WriteLine("Pressione ENTER para sair,e execute o programa novamente");
                Console.ReadKey();
                Console.ResetColor();
                Environment.Exit(-1);
            }

           Console.Write("Digite a Sua Renda Mensal: ");
           rendaMensalValido = Decimal.TryParse(Console.ReadLine(), out rendaMensal);
           Console.WriteLine();

           if (valorValido && parcelasValido && rendaMensalValido)
           {
            valorParcela = valor / parcela;
            valorMaximoParcela = rendaMensal * 0.3m;

            Console.WriteLine($"Sua Quantidade de Parcela: {valorParcela: C}");
            Console.WriteLine($"Parcela Maxima: {valorMaximoParcela:C}");

            if (valorParcela <= valorMaximoParcela)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Parabens,seu credito foi aprovado!!! ");
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Infelizmente, seu credito não foi aprovado!!! ");
            }
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Pressione ENTER para sair!");
                Console.WriteLine("Obrigado,volte sempre!");
                Console.ReadKey();
           }
        }
    } 
}