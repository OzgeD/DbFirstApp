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
            //Lazy Loading and Navigation Properties
            var category = db.Categories.Find(1);
            var products = category.Products;
            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine("Supplier:" + product.Supplier.CompanyName);
            }
            Console.ReadLine();
        }
    }
}
