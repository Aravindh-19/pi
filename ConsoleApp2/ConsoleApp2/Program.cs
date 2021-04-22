using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1, f2, result;
            Console.WriteLine("Enter f1:");
            Console.WriteLine("Enter f2:");
            f1 = Convert.ToInt32(Console.ReadLine());
            f2 = Convert.ToInt32(Console.ReadLine());
            result = f1 + f2;
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
