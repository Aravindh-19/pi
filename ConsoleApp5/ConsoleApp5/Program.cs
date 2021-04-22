using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter age:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 18 || num<60)
                { Console.WriteLine("eligible"); }
            else if (num > 60)
                 { Console.WriteLine( "Senior citizen"); }
            else
                { Console.WriteLine("Not eligible"); }

            Console.ReadLine();
        }
    }
}
