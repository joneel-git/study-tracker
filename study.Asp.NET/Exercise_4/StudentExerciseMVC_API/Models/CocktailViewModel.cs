namespace StudentExerciseMVC_API.Models
{
    public class CocktailViewModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Drink
        {
            public string strDrink { get; set; } = string.Empty;
            public string strDrinkThumb { get; set; } = string.Empty;
            public string idDrink { get; set; } = string.Empty;
        }

        public class Root
        {
            public List<Drink>? drinks { get; set; }
        }
    }
}
