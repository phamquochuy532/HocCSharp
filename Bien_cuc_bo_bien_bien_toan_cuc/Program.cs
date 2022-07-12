using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bien_cuc_bo_bien_bien_toan_cuc
{
    internal class Program
    {
        static int value = 5;
        static void Main(string[] args)
        {
            Console.WriteLine(value);

            value = 10;
            PrintSomeThing();
            
            Console.ReadLine();
         

        }
        static void PrintSomeThing()
        {
            int value = 9;
            Console.WriteLine(value);
        }
    }
}
