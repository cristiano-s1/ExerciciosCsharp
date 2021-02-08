using System;
using System.Globalization;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 01
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
            #endregion

            #region Exercicio 02
            //int numero = int.Parse(Console.ReadLine());

            //if (numero % 2 == 0)
            //{
            //    Console.WriteLine("PAR");
            //}
            //else
            //{
            //    Console.WriteLine("IMPAR");
            //}
            #endregion

            #region Exercicio 03
            //int A, B;
            //string[] numeros = Console.ReadLine().Split(' ');
            //A = int.Parse(numeros[0]);
            //B = int.Parse(numeros[1]);

            //if (A % 2 == 0 && B % 2 == 0)
            //{
            //    Console.WriteLine("Sao Multiplos");
            //}
            //else
            //{
            //    Console.WriteLine("Nao sao Multiplos");
            //}
            #endregion

            #region Exercicio 04
            //string[] valores = Console.ReadLine().Split(' ');
            //int horaInicial = int.Parse(valores[0]);
            //int horaFinal = int.Parse(valores[1]);

            //int duracao;
            //if (horaInicial < horaFinal)
            //{
            //    duracao = horaFinal - horaInicial;
            //}
            //else
            //{
            //    duracao = 24 - horaInicial + horaFinal;
            //}

            //Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
            #endregion

            #region Exercicio 05
            //int codigo, qtd;
            //double preco = 0.00;

            //Console.WriteLine("Digite o código e quantidade:");
            //string[] valores = Console.ReadLine().Split(' ');

            //codigo = int.Parse(valores[0]);
            //qtd = int.Parse(valores[1]);

            //if (codigo == 1)
            //{
            //    preco = qtd * 4.00;
            //}
            //else if (codigo == 2)
            //{
            //    preco = qtd * 4.50;       
            //}
            //else if (codigo == 3)
            //{
            //    preco = qtd * 5.00;
            //}
            //else if (codigo == 4)
            //{
            //    preco = qtd * 2.00;
            //}
            //else if (codigo == 5)
            //{
            //    preco = qtd * 1.50;
            //}
            //else
            //{
            //    Console.WriteLine("Código não existe");
            //}
            //Console.WriteLine("Total: " + preco.ToString("F2"), CultureInfo.InvariantCulture);
            #endregion

            #region Exercicio 06
            double numero = double.Parse(Console.ReadLine());

            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            #endregion

            #region Exercicio 07
            //string[] valores = Console.ReadLine().Split(' ');
            //double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            //if (x == 0.0 && y == 0.0)
            //{
            //    Console.WriteLine("Origem");
            //}
            //else if (x == 0.0)
            //{
            //    Console.WriteLine("Eixo Y");
            //}
            //else if (y == 0.0)
            //{
            //    Console.WriteLine("Eixo X");
            //}
            //else if (x > 0.0 && y > 0.0)
            //{
            //    Console.WriteLine("Q1");
            //}
            //else if (x < 0.0 && y > 0.0)
            //{
            //    Console.WriteLine("Q2");
            //}
            //else if (x < 0.0 && y < 0.0)
            //{
            //    Console.WriteLine("Q3");
            //}
            //else
            //{
            //    Console.WriteLine("Q4");
            //}
            #endregion

            #region Exercicio 08
            //double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double imposto;
            //if (salario <= 2000.0)
            //{
            //    imposto = 0.0;
            //}
            //else if (salario <= 3000.0)
            //{
            //    imposto = (salario - 2000.0) * 0.08;
            //}
            //else if (salario <= 4500.0)
            //{
            //    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            //}
            //else
            //{
            //    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            //}

            //if (imposto == 0.0)
            //{
            //    Console.WriteLine("Isento");
            //}
            //else
            //{
            //    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            //}
            #endregion
        }
    }
}
