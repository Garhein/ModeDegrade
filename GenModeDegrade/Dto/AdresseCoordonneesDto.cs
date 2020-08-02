using GenModeDegrade.Base;

namespace GenModeDegrade.Dto
{
    /// <summary>
    /// Adresse et coordonnées (patient, intervenant, ...).
    /// </summary>
    public class AdresseCoordonneesDto : AbstractDto
    {
        public string numeroRue;
        public string nomRue;
        public string codePostal;
        public string ville;

        /// <summary>
        /// Constructeur vide.
        /// </summary>        
        public AdresseCoordonneesDto() : base() { }

        /// <summary>
        /// Méthode <see cref="ToString"/>.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", this.numeroRue, this.nomRue, this.codePostal, this.ville);
        }
    }
}