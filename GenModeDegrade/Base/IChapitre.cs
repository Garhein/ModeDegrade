using System.Collections.Generic;

namespace GenModeDegrade.Base
{
    /// <summary>
    /// Interface de définition des comportements communs aux chapitres.
    /// </summary>
    public interface IChapitre
    {
        /// <summary>
        /// Nom du chapitre (ex : EtatCivilChapitre, AdresseCoordonneeChapitre, ...)
        /// </summary>
        string NomChapitre { get; }

        /// <summary>
        /// Initialisation des données du chapitre.
        /// </summary>
        void InitialiserChapitre();

        /// <summary>
        /// Récupération des données.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="indiCode">Code de l'individu pour lequel récupérer les données.</param>
        /// <returns></returns>
        IEnumerable<T> GetDonnees<T>(string indiCode);
    }
}