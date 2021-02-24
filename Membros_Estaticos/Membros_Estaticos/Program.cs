using System;
using System.Globalization;

namespace Membros_Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Qual é a cotação do dólar? ");
            double contacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.ValorPagar(dolar, contacao);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
