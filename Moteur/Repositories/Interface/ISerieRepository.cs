using Moteur.Metier;

namespace Moteur.Repositories.Interface
{
    public interface ISerieRepository
    {
        /// <summary>
        /// Rechercher un serie avec son Id.
        /// </summary>
        /// <param name="id">Id de la série.</param>
        /// <returns>Détail de la série.</returns>
        Serie ObtenirSerieParId(int id);
    }
}
