using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using StudentExerciseMVC_API.Models;

namespace StudentExerciseMVC_API.Controllers
{
    [Route("[controller]")]
    public class CocktailController : Controller
    {
        public async Task<IActionResult> Index()
        {
            try
            {
                // Fetch the JSON string from URL
                IEnumerable<CocktailViewModel.Drink> drinks = Enumerable.Empty<CocktailViewModel.Drink>();

                //Drinksut thecocktaildb.com API
                string url = "https://www.thecocktaildb.com/api/json/v1/1/filter.php?c=Cocktail";

                using HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage getData = await httpClient.GetAsync(url);

                if (getData.IsSuccessStatusCode)
                {
                    string result = await getData.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(result);
                    JArray drinksArray = (JArray)json["drinks"]!;

                    // Filter out null elements and convert to Drink objects
                    drinks = drinksArray
                        .Select(d => d?.ToObject<CocktailViewModel.Drink>())
                        .Where(d => d != null)
                        .Select(d => d!); // Cast to non-nullable type

                    return View("Index", drinks);
                }
                else
                {
                    Console.WriteLine("Error calling web API");
                    return View("Error");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View("Error");
            }
        }



    }
}