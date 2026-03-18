using SEÇAO10HP.Entities;
using System;
using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;
namespace SEÇAO10HP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> pd = new List<Product>();
            Console.Write("Numero de Produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"PRODUTO {i}: ");
                Console.Write("Comum, Usado ou Importado (c/u/i)? ");
                string cui = Console.ReadLine().ToLower();
                Console.Write("NOME DO PRODUTO: ");
                string name = Console.ReadLine();
                Console.Write("PREÇO DO PRODUTO: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (cui == "c")
                {
                    pd.Add(new Product(name, price));
                }
                if (cui == "u")
                {
                    Console.Write("DIGITE A DATA DE FABRICAÇÃO DO PRODUTO: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    pd.Add(new UsedProduct(name, price, date));
                }
                if (cui == "i")
                {
                    Console.Write("PREÇO DO FRETE: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pd.Add(new ImportedProduct(name, price, fee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            foreach (Product pe in pd)
            {
                Console.WriteLine(pe.PriceTag());
            }



        }
    }
}
