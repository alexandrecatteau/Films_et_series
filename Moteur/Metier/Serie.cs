using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Moteur.Metier
{
    public class Serie
    {
        [JsonProperty(PropertyName = "backdrop_path")]
        public string CheminFond { get; set; }

        [JsonProperty(PropertyName = "created_by")]
        public List<Createur> CreerPar { get; set; }

        [JsonProperty(PropertyName = "episode_run_time")]
        public List<int> DureeEpisodes { get; set; }

        [JsonProperty(PropertyName = "first_air_date")]
        public DateTime PremiereSortie { get; set; }

        [JsonProperty(PropertyName = "genres")]
        public List<Genre> Genres { get; set; }

        [JsonProperty(PropertyName = "homepage")]
        public string PageAcceuil { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "in_production")]
        public bool EstEnProduction { get; set; }

        [JsonProperty(PropertyName = "languages")]
        public List<string> Languages { get; set; }

        [JsonProperty(PropertyName = "last_air_date")]
        public DateTime DateDerniereSortie { get; set; }

        [JsonProperty(PropertyName = "last_episode_to_air")]
        public Episode DernierEpisode { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Nom { get; set; }

        [JsonProperty(PropertyName = "next_episode_to_air")]
        public Episode ProchainEpisode { get; set; }

        [JsonProperty(PropertyName = "networks")]
        public List<Network> Networks { get; set; }

        [JsonProperty(PropertyName = "number_of_episodes")]
        public int NombreEpisode { get; set; }

        [JsonProperty(PropertyName = "number_of_seasons")]
        public int NombreSaison { get; set; }

        [JsonProperty(PropertyName = "origin_country")]
        public List<string> PaysOrigine { get; set; }

        [JsonProperty(PropertyName = "original_language")]
        public string LangueOriginale { get; set; }

        [JsonProperty(PropertyName = "original_name")]
        public string NomOriginal { get; set; }

        [JsonProperty(PropertyName = "overview")]
        public string Resume { get; set; }

        [JsonProperty(PropertyName = "popularity")]
        public double Popularite { get; set; }

        [JsonProperty(PropertyName = "poster_path")]
        public string CheminAffiche { get; set; }

        [JsonProperty(PropertyName = "production_companies")]
        public List<SocieteProduction> SocieteProductions { get; set; }

        [JsonProperty(PropertyName = "seasons")]
        public List<Saison> Saisons { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "vote_average")]
        public double MoyenneVote { get; set; }

        [JsonProperty(PropertyName = "vote_count")]
        public int NombreVote { get; set; }
    }
}
