using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeFixacao3
{
    internal class Student
    {
        public string Name;

        public double Nota1;

        public double Nota2;

        public double Nota3;


        public void Media()
        {
           double media = Nota1 + Nota2 + Nota3;

            if (media >= 60)
            {
                Console.WriteLine($"NOTA FINAL = {media.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine($"NOTA FINAL = {media.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"Faltaram {(60 - media).ToString("F2",CultureInfo.InvariantCulture)} Pontos");
            }
        }

         
    }
}
