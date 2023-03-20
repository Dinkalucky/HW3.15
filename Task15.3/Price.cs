using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15._3
{
    public struct Price
    {
        private string productName;
        private string shopName;
        private int price;

        private Price[] priceArray;

        public void PriceArray()
        {
            priceArray = new Price[3];

            for (int i = 0; i < priceArray.Length; i++)
            {
                Console.WriteLine($"Введіть назву {i + 1} товару");
                priceArray[i].productName = Console.ReadLine();

                Console.WriteLine($"Введіть назву {i + 1} магазину");
                priceArray[i].shopName = Console.ReadLine();

                Console.WriteLine($"Введіть ціну {i + 1} товару");
                priceArray[i].price = Int32.Parse(Console.ReadLine());

            }
        }

        public void ShowArray()
        {
            var sortedArray = priceArray.OrderBy(x => x.shopName).ToArray();
            foreach (var product in sortedArray)
            {
                Console.Write(product.productName + "-" + product.shopName + "-" + product.price + "грн \n");
            }
        }

        public void ProductsFromShop(string nameOfShop)
        {
                var productsFromShop = priceArray.Where(n => n.shopName == nameOfShop).Select(x => new
                {
                    x.productName,
                    x.price
                }).ToArray();
               
                    if (productsFromShop.Length != 0)
                    {
                        Console.WriteLine($"У магазині {nameOfShop} продають:");

                        foreach (var product in productsFromShop)
                        {
                            Console.Write(product.productName + " - " + product.price + " грн\n");
                        }
                    }
                    else
                    {
                        throw new Exception("Такого магазину немає, спобуйте іншу назву");
                    }
        }
    }
}
