namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Funcion to display the n number Fibonacci series ..
            //input number of Fibonacci series 8:
            //The Fibonacci series of 8 numbers is;
            //0 1 1 2 3 5 8 13
            /*
            F_0 = 0;
            F_1 = 1;
            F_2 = 1;
            F_3 = 2;
            F_4 = 3;
            F_5 = 5;
            starting with 0 and 1
            Sequence: 0,1,1,2,3,5,8,13..
            */
            int n1 = 0, n2 = 1, nxtNum, userINt;

            Console.Write("Enter the number of numbers to print: ");
            string input = Console.ReadLine();
            userINt = int.Parse(input);

            if (userINt == 0)
            {
                Console.WriteLine("Enter a number bigger than 0, please.. ");
            }
            else
            {
                for (int i = 0; i < userINt; i++)
                {
                    nxtNum = n1 + n2; // Calculate the next Fibonacci number
                    Console.WriteLine(nxtNum);

                    n1 = n2; // Update n1 to be the current n2
                    n2 = nxtNum; // Update n2 to be the calculated next number
                }
            }
            Console.ReadLine();
        }
    }
}
