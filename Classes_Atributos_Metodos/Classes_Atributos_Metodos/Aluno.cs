using System.Globalization;

namespace Classes_Atributos_Metodos
{
    class Aluno
    {
        public string Nome { get; set; }

        public double A, B, C;

        public double NotaFinal()
        {
            return A + B + C;
        }

        public override string ToString()
        {
            return NotaFinal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
