using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
            if(age<18)
                { Console.WriteLine("Can't vote"); }
            else
                { Console.WriteLine("Can vote"); }
            Console.ReadLine();
        }
    }
}
