using System;
using System.Globalization;

namespace EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 01
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;

            Console.WriteLine($"SOMA: {soma}");
            #endregion

            #region Exercicio 02
            //double R, A, pi = 3.14159;
            //R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //A = pi * R * R;

            //Console.WriteLine("A=" + A.ToString("F4"), CultureInfo.InvariantCulture);
            #endregion

            #region Exercicio 03
            //int A, B, C, D;
            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());
            //C = int.Parse(Console.ReadLine());
            //D = int.Parse(Console.ReadLine());
            //int diferenca = (A * B - C * D);

            //Console.WriteLine("DIFERENCA = " + diferenca);
            #endregion

            #region Exercicio 04
            //int numero;
            //double horas, valor;

            //numero = int.Parse(Console.ReadLine());
            //horas = double.Parse(Console.ReadLine());
            //valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double salario = horas * valor;

            //Console.WriteLine("NUMBER = " + numero);
            //Console.WriteLine("SALARY = U$ " + salario.ToString("F2"), CultureInfo.InvariantCulture);
            #endregion

            #region Exercicio 05
            //int codigo, qtd;
            //double valor;

            //string[] valores = Console.ReadLine().Split(' ');
            //codigo = int.Parse(valores[0]);
            //qtd = int.Parse(valores[1]);
            //valor = double.Parse(valores[2], CultureInfo.InvariantCulture);
            //double total = qtd * valor;

            //Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"), CultureInfo.InvariantCulture);
            #endregion

            #region Exercicio 06
            //double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            //string[] valores = Console.ReadLine().Split(' ');
            //A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //triangulo = A * C / 2.0;
            //circulo = 3.14159 * C * C;
            //trapezio = (A + B) / 2.0 * C;
            //quadrado = B * B;
            //retangulo = A * B;

            //Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
            #endregion
        }
    }
}
