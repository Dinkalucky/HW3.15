using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Price price = new Price();
            Console.OutputEncoding = Encoding.UTF8;

            price.PriceArray();
            price.ShowArray();

            Console.WriteLine("Товари якого магазину вас цікавлять?");
            string shopName = Console.ReadLine();
            try
            {
                price.ProductsFromShop(shopName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                shopName = Console.ReadLine();
                price.ProductsFromShop(shopName);
            }
            Console.ReadLine();
        }
    }
}
