using Moteur.Metier;
using Moteur.Repositories.Interface;
using Moteur.Utilitaires;
using Moteur.Utilitaires.Interface;
using Moteur.Utilitaires.Validateur;
using Newtonsoft.Json;

namespace Moteur.Repositories
{
    public class SerieRepository : ISerieRepository
    {
        /// <summary>
        /// Objet pour télécharger depuis une URL.
        /// </summary>
        private ITelecharcherData _telechargerData;

        /// <summary>
        /// Rechercher une série avec son Id.
        /// </summary>
        /// <param name="id">Id de la série.</param>
        /// <returns>Détail de la série.</returns>
        public Serie ObtenirSerieParId(int id)
        {
            id.Valider(nameof(id)).StrictementPositif();

            _telechargerData = new TelecharcherData();

            URL url = new URL(id.ToString(), Enum.EnumTypeRecherche.Serie);
            url.Valider(nameof(url));

            string data = _telechargerData.ObtenirData(url);
            data.Valider(nameof(data));

            return JsonConvert.DeserializeObject<Serie>(data);
        }
    }
}
