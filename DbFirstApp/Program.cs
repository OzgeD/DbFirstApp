using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DbFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();
            //Eager Loading
            var category = db.Categories.Include("Products").Include("Products.Supplier").FirstOrDefault(x => x.CategoryID == 1);
            var products = category.Products;
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.Supplier.CompanyName);
            }
            Console.ReadLine();
            //Single query occurred in sql profiler.

        }
    }
}
