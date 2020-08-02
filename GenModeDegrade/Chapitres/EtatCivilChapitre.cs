using GenModeDegrade.Base;
using GenModeDegrade.Dto;
using System;
using System.Collections.Generic;

namespace GenModeDegrade.Chapitres
{
    /// <summary>
    /// État civil.
    /// </summary>
    public class EtatCivilChapitre : AbstractChapitre
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="dateDebPeriodeRecherche">Date de début de la période de recherche.</param>
        /// <param name="dateFinPeriodeRecherche">Date de fin de la période de recherche.</param>
        /// <param name="servCode">Code du service pour lequel charger les données.</param>
        /// <param name="listeIndiCode">Liste des codes des individus pour lesquels charger les données.</param>
        public EtatCivilChapitre(DateTime dateDebPeriodeRecherche,
                                 DateTime dateFinPeriodeRecherche,
                                 string servCode,
                                 List<string> listeIndiCode) : base(dateDebPeriodeRecherche,
                                                                    dateFinPeriodeRecherche,
                                                                    servCode,
                                                                    listeIndiCode) { }

        #region Implémentations

        /// <summary>
        /// Initialisation des données du chapitre.
        /// </summary>
        public override void InitialiserChapitre() 
        {
            this._listeDto.Add(new EtatCivilDto() { indiCodeExtraction = "XV01", prenom = "Xavier", nom = "VILLEMIN" });
            this._listeDto.Add(new EtatCivilDto() { indiCodeExtraction = "MV01", prenom = "Marjorie", nom = "VILLEMIN" });
            this._listeDto.Add(new EtatCivilDto() { indiCodeExtraction = "EV01", prenom = "Elias", nom = "VILLEMIN" });
            this._listeDto.Add(new EtatCivilDto() { indiCodeExtraction = "HV01", prenom = "Hugo", nom = "VILLEMIN" });        
        }

        #endregion
    }
}