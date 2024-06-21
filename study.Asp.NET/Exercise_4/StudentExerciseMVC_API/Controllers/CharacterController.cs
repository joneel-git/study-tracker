using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json;
using StudentExerciseMVC_API.Models;
using System.Net.Http.Headers;


namespace StudentExerciseMVC_API.Controllers
{
    public class CharacterController : Controller
    {
        //public IActionResult Index()
        public async Task<IActionResult> Index()
        {
            //Fetch the JSON string from URL
            List<CharacterViewModel.Characters>? characters = new List<CharacterViewModel.Characters>();

            if (characters != null && !characters.Any()) //if empty and doesnt contain anything
            {
                // Add new item
                //Characters https://mocki.io/fake-json-api APIsta
                string url = "https://mocki.io/v1/14de2695-50c8-436e-bca5-00b3c29c17af";

                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //getting our JSON from url
                HttpResponseMessage getData = await httpClient.GetAsync(url);

                if (getData.IsSuccessStatusCode)
                {
                    string results = await getData.Content.ReadAsStringAsync();

                    characters = JsonConvert.DeserializeObject<List<CharacterViewModel.Characters>>(results);
                }
                else
                {
                    Console.WriteLine("Error calling web API..");
                }
            }
            return View(characters);
        }
    }
}
