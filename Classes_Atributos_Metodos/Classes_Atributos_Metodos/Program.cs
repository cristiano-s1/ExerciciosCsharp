using System;
using System.Globalization;

namespace Classes_Atributos_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio01
            //Pessoa pessoa1 = new Pessoa();
            //Pessoa pessoa2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa:");
            //Console.Write("Nome: ");
            //pessoa1.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //pessoa1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados da segunda pessoa:");
            //Console.Write("Nome: ");
            //pessoa2.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //pessoa2.Idade = int.Parse(Console.ReadLine());


            //if (pessoa1.Idade > pessoa2.Idade)
            //{
            //    Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            //}
            //else
            //{
            //    Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
            //}

            #endregion

            #region Exercicio02
            //Funcionario funcionario = new Funcionario();

            //Console.Write("Nome: ");
            //funcionario.Nome = Console.ReadLine();

            //Console.Write("Salário bruto: ");
            //funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Imposto: ");
            //funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Funcionário: " + funcionario);

            //Console.WriteLine();

            //Console.Write("Digite a porcentagem para aumentar o salário: ");
            //double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //funcionario.AumentarSalario(porcentagem);

            //Console.WriteLine();

            //Console.Write("Dados atualizados: " + funcionario);
            #endregion

            #region Exercicio03
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("NOTA FINAL = " + aluno);

            Console.WriteLine();

            if (aluno.NotaFinal() > 60.00)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
            }
            #endregion

        }
    }
}
