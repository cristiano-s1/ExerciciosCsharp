
namespace Membros_Estaticos
{
    class ConversorDeMoeda
    {
        public static double IOF = 6;

        public static double ValorPagar(double dolar, double cotacao)
        {
            double total = dolar * cotacao;
            return total + total * 6 / 100;
        }
    }
}
