using System.Globalization;

namespace ExercicioDeFixacao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Console.WriteLine("Entre a largura e altura do retângulo:");

            rect.Width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            rect.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(rect);

        }
    }
}
