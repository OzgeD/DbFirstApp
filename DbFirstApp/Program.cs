using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();

            var sales = db.Sales_by_Year(new DateTime(1997, 1, 1),DateTime.Now);
            foreach (var sale in sales)
            {
                Console.WriteLine(sale.Year + "/" + sale.Subtotal);
            }
            Console.ReadLine();

            //var products = db.Ten_Most_Expensive_Products();
            //foreach(var pro in products)
            //{
            //    Console.WriteLine(pro.TenMostExpensiveProducts + "/" + pro.UnitPrice);
            //}
            //Console.ReadLine();

            //var categories = db.Categories;

            //foreach (var cat in categories)
            //{
            //    Console.WriteLine(cat.CategoryName);
            //}

        }
    }
}
