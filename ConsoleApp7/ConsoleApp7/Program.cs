using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] arr = new int[5];
                int sum = 0;
                Console.WriteLine("Enter the elements:");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    sum = arr[i] + sum;
                }

                Console.WriteLine("sum is :" + sum);
                Console.ReadLine();
            }
        }
    }
}
