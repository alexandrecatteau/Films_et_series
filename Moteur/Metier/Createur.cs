using Newtonsoft.Json;

namespace Moteur.Metier
{
    public class Createur
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "credit_id")]
        public string IdCredit { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Nom { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public int Genre { get; set; }

        [JsonProperty(PropertyName = "profile_path")]
        public string CheminProfil { get; set; }
    }
}
