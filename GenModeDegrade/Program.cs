using GenModeDegrade.Chapitres;
using GenModeDegrade.Dto;
using System;
using System.Collections.Generic;

namespace GenModeDegrade
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listeMalaIndiCode = new List<string>() { "XV01", "MV01", "EV01", "HV01" };

            // =-=-=-
            // Construction des chapitres (récupération de toutes les données)
            // =-=-=-

            EtatCivilChapitre etatCivilModel = new EtatCivilChapitre(DateTime.Now, DateTime.Now, "HAD", listeMalaIndiCode);
            IntervenantChapitre intervModel  = new IntervenantChapitre(DateTime.Now, DateTime.Now, "HAD", listeMalaIndiCode);           

            // =-=-=-
            // Affichage (simulation de la génération)
            // =-=-=-

            foreach (string malaIndiCode in listeMalaIndiCode)
            {
                // =-=-=-
                // État civil
                // =-=-=-

                Console.WriteLine(string.Format("Code '{0}'", malaIndiCode));
                Console.WriteLine("  CHAPITRE ETAT CIVIL");

                IEnumerable<EtatCivilDto> etatCivil = etatCivilModel.GetDonnees<EtatCivilDto>(malaIndiCode);
                foreach (EtatCivilDto dto in etatCivil)
                {
                    Console.WriteLine("    " + dto.ToString());
                }

                // =-=-=-
                // Intervenants
                // =-=-=-

                Console.WriteLine("  CHAPITRE INTERVENANTS");

                IEnumerable<IntervenantDto> intervenants = intervModel.GetDonnees<IntervenantDto>(malaIndiCode);
                foreach (IntervenantDto interv in intervenants)
                {
                    Console.WriteLine("    " + interv.ToString());

                    // TODO: comment éviter d'avoir à réaliser des CAST ?
                    IEnumerable<AdresseCoordonneesDto> adresses = intervModel.adresses.GetDonnees<AdresseCoordonneesDto>(interv.indiCode);
                    foreach (AdresseCoordonneesDto adr in adresses)
                    {
                        Console.WriteLine("    " + adr.ToString());
                    }
                }

                Console.WriteLine("");
            }
        }
    }
}
