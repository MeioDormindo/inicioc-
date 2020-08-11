using System;
using System.Globalization;

namespace ProdutoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de produtos a serem registrados: ");
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o nome do produto {i+1} : ");
                string name = Console.ReadLine();
                Console.Write($"Digite o preço do produto {i+1} : ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                vect[i] = new Product { Name = name, Price = price };
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine("O preço médio é : " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

