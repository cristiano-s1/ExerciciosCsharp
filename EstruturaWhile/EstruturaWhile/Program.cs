using System;

namespace EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Exercicio 01

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
            #endregion

            #region Exercicio 02
            //string[] valores = Console.ReadLine().Split(' ');
            //int x = int.Parse(valores[0]);
            //int y = int.Parse(valores[1]);

            //while (x != 0 && y != 0)
            //{
            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine("primeiro");
            //    }
            //    else if (x < 0 && y > 0)
            //    {
            //        Console.WriteLine("segundo");
            //    }
            //    else if (x < 0 && y < 0)
            //    {
            //        Console.WriteLine("terceiro");
            //    }
            //    else
            //    {
            //        Console.WriteLine("quarto");
            //    }
            //    valores = Console.ReadLine().Split(' ');
            //    x = int.Parse(valores[0]);
            //    y = int.Parse(valores[1]);
            #endregion

            #region Exercicio 03
            //int alcool = 0;
            //int gasolina = 0;
            //int diesel = 0;

            //int tipo = int.Parse(Console.ReadLine());

            //while (tipo != 4)
            //{
            //    if (tipo == 1)
            //    {
            //        alcool = alcool + 1;
            //    }
            //    else if (tipo == 2)
            //    {
            //        gasolina = gasolina + 1;
            //    }
            //    else if (tipo == 3)
            //    {
            //        diesel = diesel + 1;
            //    }

            //    tipo = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("MUITO OBRIGADO");
            //Console.WriteLine("Alcool: " + alcool);
            //Console.WriteLine("Gasolina: " + gasolina);
            //Console.WriteLine("Diesel: " + diesel);
            #endregion

        }
    }
}
