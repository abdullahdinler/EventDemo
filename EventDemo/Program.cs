using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(50);
            product.ProductName = "Samsung";
            Product product2 = new Product(50);
            product2.ProductName = "Redmi";
            product2.StockControlEvent += Product2_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                product.Sell(10);
                product2.Sell(10);
                Console.ReadLine();
            }
        }

        private static void Product2_StockControlEvent()
        {
            Console.WriteLine("Redmi about to finish!!!");
        }
    }
}
