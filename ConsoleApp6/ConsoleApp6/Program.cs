using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ur choice \n 1.ADD \n 2.Sub ");
            int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
            {
                case 1:
                    Console.WriteLine("ADD ");
                    break;
                case 2:
                    Console.WriteLine("SUB ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
