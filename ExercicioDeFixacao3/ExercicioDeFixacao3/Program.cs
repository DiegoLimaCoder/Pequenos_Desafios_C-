using System.Globalization;

namespace ExercicioDeFixacao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.Write("Nome do Aluno: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Digite as três nota do aluno: ");
            student.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            student.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            student.Media();

        }
    }
}
