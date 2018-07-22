using System;
using System.ComponentModel;
using System.Linq;

namespace Moteur.Utilitaires
{
    public static class EnumExtension
    {
        /// <summary>
        /// Recuppération des attributs.
        /// </summary>
        private static T ObtenirAttribut<T>(this System.Enum value) where T : Attribute
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
            return (T)attributes[0];
        }

        /// <summary>
        /// Récupéeatrion de la description de l'enum.
        /// </summary>
        /// <returns>Description de l'enum.</returns>
        public static string ObtenirNom(this System.Enum value)
        {
            var attribute = value.ObtenirAttribut<DescriptionAttribute>();
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
