using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace ReadAzuredb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Code that may throw an exception

                Console.Write("Connect to SQL Server and Demo some stuff.. ");
                //how to connect the data is typically found in the connection string

                MyEnviroment env = new MyEnviroment();
                env.SigninAndRunQuery();
            }
            catch (Exception e)
            {
                //login failed for user
                Console.WriteLine("");
                MyEnviroment env = new MyEnviroment();
                env.throwError("");
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }
    }
}
