using System;

namespace Moteur.Utilitaires.Validateur
{
    /// <summary>
    /// Valide les entrées.
    /// </summary>
    public static partial class Validateur
    {
        /// <summary>
        /// Léve une exception si le paramètre est inférieur à 1.
        /// </summary>
        public static void StrictementPositif(this int i)
        {
            if (i < 1)
            {
                throw new ArgumentException($"Le paramétre {_validateurObjet.NomParametre} doit être supérieur à 1.");
            }
        }

        /// <summary>
        /// Léve une exception si le paramètre est inférieur à 0.
        /// </summary>
        public static void Positif(this int i)
        {
            if (i < 0)
            {
                throw new ArgumentException($"Le paramétre {_validateurObjet.NomParametre} ne peut pas être négatif.");
            }
        }
    }
}
