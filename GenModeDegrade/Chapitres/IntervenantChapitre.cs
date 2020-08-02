using GenModeDegrade.Base;
using GenModeDegrade.Dto;
using System;
using System.Collections.Generic;

namespace GenModeDegrade.Chapitres
{
    /// <summary>
    /// Intervenant du patient.
    /// </summary>
    public class IntervenantChapitre : AbstractChapitre
    {
        public AdresseCoordonneesChapitre adresses;

        /// <summary>
        /// Constructeur.
        /// </summary>
        /// <param name="dateDebPeriodeRecherche">Date de début de la période de recherche.</param>
        /// <param name="dateFinPeriodeRecherche">Date de fin de la période de recherche.</param>
        /// <param name="servCode">Code du service pour lequel charger les données.</param>
        /// <param name="listeIndiCode">Liste des codes des individus pour lesquels charger les données.</param>
        public IntervenantChapitre(DateTime dateDebPeriodeRecherche,
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
            // =-=-=-
            // Intervenants
            // =-=-=-

            // Intervenants du patient XV01
            this._listeDto.Add(new IntervenantDto() { indiCodeExtraction = "XV01", indiCode = "HV04", prenom = "Hubert", nom = "VONDERSHER" });
            this._listeDto.Add(new IntervenantDto() { indiCodeExtraction = "XV01", indiCode = "FC04", prenom = "François", nom = "COINCE" });


            // Intervenants du patient MV01
            this._listeDto.Add(new IntervenantDto() { indiCodeExtraction = "MV01", indiCode = "HV04", prenom = "Hubert", nom = "VONDERSHER" });

            // Intervenants du patient EV01
            this._listeDto.Add(new IntervenantDto() { indiCodeExtraction = "EV01", indiCode = "HV04", prenom = "Hubert", nom = "VONDERSHER" });
            this._listeDto.Add(new IntervenantDto() { indiCodeExtraction = "EV01", indiCode = "JL04", prenom = "Julie", nom = "LANG" });

            // Intervenants du patient HV01
            this._listeDto.Add(new IntervenantDto() { indiCodeExtraction = "HV01", indiCode = "HV04", prenom = "Hubert", nom = "VONDERSHER" });

            // =-=-=-
            // Adresses des intervenants
            // =-=-=-

            this.adresses = new AdresseCoordonneesChapitre(this._dateDebPeriodeRecherche,
                                                           this._dateFinPeriodeRecherche,
                                                           this._servCode,
                                                           new List<string>() { "HV04", "FC04", "JL04" });
        }

        #endregion
    }
}