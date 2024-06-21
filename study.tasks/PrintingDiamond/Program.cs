using System.Data;
using System.Runtime.ExceptionServices;

namespace PrintingDiamond
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("enter number of rows.. ");
            int num = int.Parse(Console.ReadLine());
            //the main loop to print the 5 rows 
            // int num = 5;
            for (int row = 1; row <= num; row++) //lets say this number 5
            {
                for (int spaces = row; spaces <= num; spaces++)
                {
                    Console.Write(" ");
                }
                //this loop adds the stars
                for (int j = 1; j <= row; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            //----------------------------------------//
            for (int row = num; row >= 1; row--) //this loop has to be number 5 - row
            {
                for (int spaces = num; spaces >= row - 1; spaces--)
                {
                    Console.Write(" ");
                }
                //this loop adds the stars
                for (int j = 1; j < row; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}