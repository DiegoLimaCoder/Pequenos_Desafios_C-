using PrimeiroProjeto;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar ? ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares você vai comprar? ");
            double quantidadeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double volorTotal = ConversorDeMoedas.DolarToReais(cotacaoDolar, quantidadeDolar);

            Console.WriteLine("Valor a ser pago em reais = " + volorTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}