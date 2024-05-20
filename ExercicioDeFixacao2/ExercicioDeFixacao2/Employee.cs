using System.Globalization;

namespace ExercicioDeFixacao2
{
    internal class Employee
    {
        public string Name;
        public double Salary;
        public double Tax;

        public double NetSalary()
        {
            return Salary - Tax;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * (percentage / 100);
        }

        public override string ToString()
        {
            return $"{Name}, $ {NetSalary().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
