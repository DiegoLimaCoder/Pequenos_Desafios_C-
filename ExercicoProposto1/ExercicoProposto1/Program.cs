using System.Globalization;

namespace ExercicoProposto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            Console.WriteLine("Entre os dados do produto: ");
            
            Console.Write("Nome: ");
            product.Name = Console.ReadLine();

            Console.Write("Preço: ");
            product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade de estoque: ");
            product.Quantity  = int.Parse(Console.ReadLine());

            Console.WriteLine(product);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qta = int.Parse(Console.ReadLine());
            product.AddProducts(qta);
            Console.WriteLine(product);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qta = int.Parse(Console.ReadLine());
            product.RemoveProducts(qta);
            Console.WriteLine(product);

        }
    }
}
