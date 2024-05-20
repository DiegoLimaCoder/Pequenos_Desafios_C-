using System.Globalization;

namespace PrimeiroProjeto
{
    internal class ConversorDeMoedas
    {
        public static double IOF = 0.06;

        public static double DolarToReais(double cotacaoDoDolar, double quantidadeDolar)
        {
            double total = cotacaoDoDolar * quantidadeDolar;
            return total + (total * IOF);
        }

    }
}
