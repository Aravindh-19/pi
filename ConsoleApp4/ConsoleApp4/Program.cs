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
            int[,] arr = new int[2, 2];
            int[,] trans = new int[2, 2];
            Console.WriteLine("Enter the elements:");
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(0); col++)
                {
                    arr[row, col] = Convert.ToInt32(Console.ReadLine());
                }


            }
            for (int row = 0; row < trans.GetLength(0); row++)
            {
                for (int col = 0; col < trans.GetLength(0); col++)
                {
  
                    trans[row, col] = arr[col, row];
                }


            }
            for (int row = 0; row < trans.GetLength(0); row++)
            {
                for (int col = 0; col < trans.GetLength(0); col++)
                {
                    Console.Write(trans[row, col] + "\t");
                }

                Console.Write("\n");
            }


            Console.ReadLine();
        }
    }
}
