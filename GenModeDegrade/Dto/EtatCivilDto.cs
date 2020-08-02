using GenModeDegrade.Base;

namespace GenModeDegrade.Dto
{
    /// <summary>
    /// État civil.
    /// </summary>
    public class EtatCivilDto : AbstractDto
    {
        public string prenom;
        public string nom;

        /// <summary>
        /// Constructeur vide.
        /// </summary>        
        public EtatCivilDto() : base() { }

        /// <summary>
        /// Méthode <see cref="ToString"/>.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} ({2})", this.prenom, this.nom, this.indiCodeExtraction);
        }
    }
}