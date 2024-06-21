using Newtonsoft.Json;

namespace Con_Api_Characters2
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
            //https://dummyjson.com/products
            //Characters from 
            string url = "https://dummyjson.com/products";

            HttpClient httpClient = new HttpClient();

            try
            {
                var httpResponseMessage = await httpClient.GetAsync(url);

                //read the string from the response's content
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();

                //print the json response
                Console.WriteLine(jsonResponse + "\n");

                //desirelize the JSON array into a collection type such as a list.
                var products = JsonConvert.DeserializeObject<Root>(jsonResponse);

                //print the list elements using a foreachloop
                foreach (var product in products.products)
                {
                    Console.WriteLine($"\nID: {product.id} \nProduct: {product.title}");

                    //print images of every objects (products)
                    for (int i = 0; i < product.images.Count; i++)
                    {
                        Console.WriteLine(
                            string.Format("Picture: {0}",
                            product.images[i].ToString()
                            ));
                    }
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
public class Product
{
    public int id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public int price { get; set; }
    public double discountPercentage { get; set; }
    public double rating { get; set; }
    public int stock { get; set; }
    public string brand { get; set; }
    public string category { get; set; }
    public string thumbnail { get; set; }
    public List<string> images { get; set; } //root doesnt have images??
}

public class Root
{
    public List<string> images { get; set; }
    public List<Product> products { get; set; }
    public int total { get; set; }
    public int skip { get; set; }
    public int limit { get; set; }
}
