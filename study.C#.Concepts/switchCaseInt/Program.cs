using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace switchCaseInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number.. ");
            int userAnswer = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckInputNumber(userAnswer));
            Console.ReadLine();
        }

        public static string CheckInputNumber(int userAnswer)
        {
            while (userAnswer != 1 && userAnswer != 2 && userAnswer != 3)
            {
                Console.WriteLine("Wrong number, please enter a number 1, 2 or 3.. ");
                Console.Write("Please anter a number.. ");
                userAnswer = int.Parse(Console.ReadLine());
            }  //while loop add code that you want to keep repeating inside it

            string result = "";
            switch (userAnswer)
            {
                case 1:
                    result = "yes thats a number 1";
                    break;
                case 2:
                    result = "yes thats a number 2";
                    break;
                case 3:
                    result = "yes thats a number 3";
                    break;
                //add more as needed
                default:
                    Console.WriteLine("wrong number..");
                    //if no condition met
                    break;
            }
            return result;
        }
    }
}
