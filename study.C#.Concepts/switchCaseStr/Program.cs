using System.Threading.Channels;

namespace switchCaseStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetStringType("random!"));
            Console.ReadLine();
        }

        static string GetStringType(string strType)
        {
            switch (strType)
            {
                case "water": //this is the string type
                    Console.WriteLine("yea water is good sometimes");
                    break;
                case "coffee": //this is the string type
                    Console.WriteLine("i only drink as a social thing not when by myself..");
                    break;
                default:
                    Console.WriteLine("its not a drink");
                    break;
            }
            return strType;
        }
    }
}
