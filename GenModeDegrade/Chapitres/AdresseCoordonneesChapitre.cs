using GenModeDegrade.Base;
using GenModeDegrade.Dto;
using System;
using System.Collections.Generic;

namespace GenModeDegrade.Chapitres
{
    /// <summary>
    /// Adresse et coordonnées (patient, intervenant, ...).
    /// </summary>
    public class AdresseCoordonneesChapitre : AbstractChapitre
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="dateDebPeriodeRecherche">Date de début de la période de recherche.</param>
        /// <param name="dateFinPeriodeRecherche">Date de fin de la période de recherche.</param>
        /// <param name="servCode">Code du service pour lequel charger les données.</param>
        /// <param name="listeIndiCode">Liste des codes des individus pour lesquels charger les données.</param>
        public AdresseCoordonneesChapitre(DateTime dateDebPeriodeRecherche,
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
            this._listeDto.Add(new AdresseCoordonneesDto() { indiCodeExtraction = "HV04", numeroRue = "3", nomRue = "Avenue du Général de Gaulle", codePostal = "54380", ville = "DIEULOUARD" });
            this._listeDto.Add(new AdresseCoordonneesDto() { indiCodeExtraction = "JL04", numeroRue = "184", nomRue = "Rue du Saule", codePostal = "54700", ville = "PONT-A-MOUSSON" });
        }

        #endregion
    }
}