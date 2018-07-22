using Newtonsoft.Json;
using System;

namespace Moteur.Metier
{
    public class Episode
    {
        [JsonProperty(PropertyName = "air_date")]
        public DateTime DateSortie { get; set; }

        [JsonProperty(PropertyName = "episode_number")]
        public int NumeroEpisode { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Nom{ get; set; }

        [JsonProperty(PropertyName = "overview")]
        public string Resume { get; set; }

        [JsonProperty(PropertyName = "production_code")]
        public string CodeProduction{ get; set; }

        [JsonProperty(PropertyName = "season_number")]
        public int NumeroSaison { get; set; }

        [JsonProperty(PropertyName = "show_id")]
        public int IdShow{ get; set; }

        [JsonProperty(PropertyName = "still_path")]
        public string Chemin { get; set; }

        [JsonProperty(PropertyName = "vote_average")]
        public double MoyenneVote { get; set; }

        [JsonProperty(PropertyName = "vote_count")]
        public int NombreVote { get; set; }
    }
}
