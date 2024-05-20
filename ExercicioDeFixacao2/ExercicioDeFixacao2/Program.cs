using System.Globalization;

namespace ExercicioDeFixacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Console.Write("Nome: ");
            emp.Name = Console.ReadLine();

            Console.Write("Salário bruto: ");
            emp.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            emp.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {emp.Name}, $ {emp.NetSalary().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            emp.IncreaseSalary(percentage);

            Console.WriteLine($"Dados atualizados: {emp}");

        }
    }
}
