using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoProposto1
{
    internal class Product
    {
        public string Name;
        public double Price;
        public int Quantity;


        public double TotalValueStock()
        {
            return Quantity * Price;
        }

        public void AddProducts(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProducts(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return $"Dados do produto: {Name}, " +
                $"$ {Price.ToString("F2",CultureInfo.InvariantCulture)}, " +
                $"{Quantity} unidades, " +
                $"Total: {TotalValueStock().ToString("F2",CultureInfo.InvariantCulture)}";
        }





    }
}
