using Newtonsoft.Json;
using System;

namespace Moteur.Metier
{
    public class Saison
    {
        [JsonProperty(PropertyName = "air_date")]
        public string DateSortie { get; set; }

        [JsonProperty(PropertyName = "episode_count")]
        public int NombreEpisode { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id{ get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Nom{ get; set; }

        [JsonProperty(PropertyName = "overview")]
        public string Resume{ get; set; }

        [JsonProperty(PropertyName = "poster_path")]
        public string CheminAffiche { get; set; }

        [JsonProperty(PropertyName = "season_number")]
        public int NombreSaison{ get; set; }
    }
}
