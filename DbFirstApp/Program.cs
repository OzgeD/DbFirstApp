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
            var result = (from p in db.Products
                         join c in db.Categories
                         on p.CategoryID equals c.CategoryID
                         group new { c,p } by new { c.CategoryName } into g
                         select new
                         {
                             g.Key.CategoryName,
                             NumberOfProducts=g.Count(),
                             TotalPrice = g.Sum(x=>x.p.UnitPrice),
                             MaxPrice = g.Max(x=>x.p.UnitPrice),
                             MinPrice = g.Min(x => x.p.UnitPrice)
                         }).Where(x=>x.TotalPrice>300);

            //var result = from p in db.Products
            //             group p by p.CategoryID into g
            //             select new
            //             {
            //                 g.Key,
            //                 NumberOfProducts = g.Count()
            //             };

            //var result = from c in db.Categories
            //             join p in db.Products
            //             on c.CategoryID equals p.ProductID
            //             orderby p.UnitPrice descending
            //             select new
            //             {
            //                 p.ProductName,
            //                 c.CategoryName,
            //                 p.UnitPrice
            //             };


            ConsoleTable.From(result).Write();
            Console.ReadLine();

        }
    }
}
