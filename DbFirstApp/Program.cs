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
            //Immediate Mode vs Defered Mode
            //Immediate'da kodun çağrılmasıyla beraber sql profiler'a sorgu gidiyor
            //var categories = db.Categories.ToList(); //Immediate Mode

            //Defered Mode'da ise kodun çağrılmasıyla sql profiler'a sorgu gitmiyor,
            //categories'e ihtiyaç duyulup kullanıldığında sql profiler'a sorgu gidiyor.
            var categories = db.Categories; //Defered Mode
            categories.Count();

            Console.ReadLine();
        }
    }
}
