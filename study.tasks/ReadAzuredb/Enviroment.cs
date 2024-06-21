using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReadAzuredb
{
    class MyEnviroment
    {
        public string line2 = "hello world";

        public void SigninAndRunQuery()
        {
            /*
            //first a streamReader to read from a file login credentials
            //second is an SQLreader for reading queries
              
             a connection string acts as a blueprint for establishing a
             connection between an application and a database by providing all the necessary
             information required to connect,
            "C:\\Users\\userName\\Desktop\\connectionString.txt"
            
            this program only works if you have
            username
            password
            inside connectionString.txt

             */
            string userName = Environment.UserName;
            string path = $"C:\\Users\\{userName}\\Desktop\\MyText.txt";
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (StreamReader reader = new StreamReader(file)) // --StreamReader-- searching for file credential
            {
                if (File.Exists(path)) //-----StreamReader found file..?
                {
                    ConsoleColor color1 = Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nyes file does exist.. ", color1);
                    //

                    string line1 = reader.ReadLine();
                    string line2 = reader.ReadLine();
                    //-------------------------------------------//

                    bool keepRepeating = true;
                    do
                    {
                        if (line1 == "")
                        {
                            EmptyLine();
                            keepRepeating = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("");
                            if (line1 != null) //its not empty
                            {
                                string credentials =
                                    "Server=tcp:demoeducation.database.windows.net,1433;Initial "
                                    + "Catalog=BikeStores;Persist Security Info=False;User"
                                    + $" ID={line1}; Password={line2};" //connection string
                                    + ""
                                    + "MultipleActiveResultSets=False;Encrypt=True;"
                                    + "TrustServerCertificate=False;Connection Timeout=30;";

                                string SQLquery = "Select * FROM production.brands ";

                                using (SqlConnection connection = new SqlConnection(credentials)) //it all happens within Sql connection
                                {
                                    //
                                    //
                                    SqlCommand command = new SqlCommand(SQLquery, connection);
                                    connection.Open();
                                    using (SqlDataReader reader2 = command.ExecuteReader()) // --SQLreader--
                                    {
                                        ConsoleColor color = Console.ForegroundColor =
                                            ConsoleColor.Cyan;
                                        Console.WriteLine("");
                                        Console.WriteLine(
                                            "-------------- \n--- Brands --- \n--------------"
                                        );
                                        while (reader2.Read())
                                        {
                                            Console.WriteLine(
                                                String.Format("{1}", reader2[0], reader2[1])
                                            );
                                        }
                                    }
                                } //-----  Sqlconnection method end
                            }
                            keepRepeating = false;
                            break;
                        }
                    } while (keepRepeating); //continue looping untill end of file ?????   howww??
                }
                else
                {
                    //---StreamReader did not find the file path-----
                    throwError("error");
                }
            }
        }
        public void EmptyLine()
        {
            ConsoleColor color1 = Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Line cannot be empty.. ", color1);
            Thread.Sleep(1500);
        }

        public void throwError(string e)
        {
            ConsoleColor color1 = Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nerror file doesnt exists", color1);
            Console.WriteLine(
                "you need to create a Connection string in order to connect to server" +
                "\nthe connection string containing login credentials to login in order to use database",
                color1
            );
        }
    }
}
