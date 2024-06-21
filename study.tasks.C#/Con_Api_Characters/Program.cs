using Newtonsoft.Json;

namespace Con_Api_Characters
{
    internal class Program
    {
        /*************************************************************************************
        1. Modify Main to return a Task.
        2. Install Newtonsoft.Json package (latest stable)
        3. Use the website https://json2csharp.com/ to generate classes directly from JSON.
         *************************************************************************************/
        static async Task Main(string[] args)
        {
            //Characters from 
            string url = "https://mocki.io/v1/d4867d8b-b5d5-4a48-a4ab-79131b5809b8";

            HttpClient httpClient = new HttpClient();

            try
            {
                var httpResponseMessage = await httpClient.GetAsync(url);

                //read the string from the response's content
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();

                //print the json response
                Console.WriteLine(jsonResponse + "\n");

                //desirelize the JSON array into a collection type such as a list.
                var characters = JsonConvert.DeserializeObject<List<Root>>(jsonResponse);

                //print the list elements using a foreachloop
                foreach (var character in characters)
                {
                    Console.WriteLine("Name: " + character.name);
                    Console.WriteLine("City " + character.city + "\n");
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //dispose of the httpClient
                httpClient.Dispose();
            }
            Console.ReadLine();
        }
    }
}
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Awesomeobject
{
    public int SomeProps1 { get; set; }
    public string SomeProps2 { get; set; }
}

public class Class1
{
    public int id { get; set; }
    public string user_id { get; set; }
    public Awesomeobject awesomeobject { get; set; }
    public string created_at { get; set; }
    public string updated_at { get; set; }
    public List<User> users { get; set; }
}

public class Class2
{
    public string SomePropertyOfClass2 { get; set; }
}

public class Root
{
    public string name { get; set; }
    public string city { get; set; }
}
public class User
{
    public string id { get; set; }
    public string name { get; set; }
    public string created_at { get; set; }
    public string updated_at { get; set; }
    public string email { get; set; }
    public string testanadditionalfield { get; set; }
}

