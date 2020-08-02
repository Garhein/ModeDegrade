using System;
using System.Collections.Generic;
using System.Linq;

namespace GenModeDegrade.Base
{
    /// <summary>
    /// Représentation d'un chapitre.
    /// Implémentation par défaut de <see cref="IChapitre"/>.
    /// </summary>
    public abstract class AbstractChapitre : IChapitre
    {
        // =-=-=-
        // Critères de recherche
        // =-=-=-

        protected DateTime      _dateDebPeriodeRecherche;
        protected DateTime      _dateFinPeriodeRecherche;
        protected string        _servCode;
        protected List<string>  _listeIndiCode;

        // =-=-=-
        // Données du chapitre
        // =-=-=-

        protected List<AbstractDto> _listeDto;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="dateDebPeriodeRecherche">Date de début de la période de recherche.</param>
        /// <param name="dateFinPeriodeRecherche">Date de fin de la période de recherche.</param>
        /// <param name="servCode">Code du service pour lequel charger les données.</param>
        /// <param name="listeIndiCode">Liste des codes des individus pour lesquels charger les données.</param>
        public AbstractChapitre(DateTime dateDebPeriodeRecherche,
                                DateTime dateFinPeriodeRecherche,
                                string servCode,
                                List<string> listeIndiCode)
        {
            // =-=-=-
            // Vérifications avant initialisation
            // =-=-=-

            if (dateFinPeriodeRecherche < dateDebPeriodeRecherche)
            {
                throw new ArgumentException(string.Format("{0} => Date de fin de la période de recherche inférieure à la date de début de recherche.", this.NomChapitre));
            }

            if (string.IsNullOrEmpty(servCode))
            {
                throw new ArgumentException(string.Format("{0} => Code du service non valide.", this.NomChapitre));
            }

            if (listeIndiCode == null || !listeIndiCode.Any())
            {
                throw new ArgumentException(string.Format("{0} => Liste des INDI_CODE des individus non valide.", this.NomChapitre));
            }

            this._dateDebPeriodeRecherche = dateDebPeriodeRecherche;
            this._dateFinPeriodeRecherche = dateFinPeriodeRecherche;
            this._servCode                = servCode;
            this._listeIndiCode           = listeIndiCode;
            this._listeDto                = new List<AbstractDto>();

            // Initialisation des données du chapitre
            this.InitialiserChapitre();
        }

        #region Implémentations

        /// <summary>
        /// Nom du chapitre (ex : EtatCivilChapitre, AdresseCoordonneeChapitre, ...)
        /// </summary>
        public string NomChapitre 
        { 
            get
            {
                string className = this.GetType().FullName;
                return className.Substring(className.LastIndexOf('.') + 1);
            }
        }

        /// <summary>
        /// Récupération des données.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="indiCode">Code de l'individu pour lequel récupérer les données.</param>
        /// <returns></returns>
        public IEnumerable<T> GetDonnees<T>(string indiCode)
        {
            if (string.IsNullOrEmpty(indiCode))
            {
                throw new ArgumentException(string.Format("{0} => Paramètre '{1}' non valide.", this.NomChapitre, nameof(indiCode)));
            }
            
            return this._listeDto.Where(x => x.indiCodeExtraction.Equals(indiCode)).Cast<T>();
        }

        #endregion

        #region Méthodes abstraites

        /// <summary>
        /// Initialisation des données du chapitre.
        /// </summary>
        public abstract void InitialiserChapitre();

        #endregion
    }
}