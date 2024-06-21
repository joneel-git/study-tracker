namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Check whether a given substring is present in the given string.
            //input the string: Rock'n ( roll is good ) for your soul
            //input the substring to search: roll is good
            //the substring exists in the string...

            string text = "Rock'n roll is good for your soul";
            Console.WriteLine(text);
            int startIndex = text.IndexOf("roll");
            Console.WriteLine(startIndex);

            string getSubstring = text.Substring(7, 12); //startIndex but what is end index?
            int endIndex = text.IndexOf("good"); //15 too long..
            int endIndex2 = text.IndexOf("is good"); //12
            Console.WriteLine(endIndex2);

            //Console.Write(getSubstring);

            bool hasText = text.Contains(getSubstring);
            if (hasText)
            {
                Console.WriteLine(getSubstring + " \nexists in main String");
            }
            else
            {
                Console.WriteLine("no");
            }

            Console.ReadLine();
        }
    }
}
