namespace StudentExerciseMVC_API.Models
{
    public class CharacterViewModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
        public class Characters
        {
            public string name { get; set; } = string.Empty;
            public string city { get; set; } = string.Empty;
        }


    }
}