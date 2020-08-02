using GenModeDegrade.Base;

namespace GenModeDegrade.Dto
{
    /// <summary>
    /// Intervenant du patient.
    /// </summary>
    public class IntervenantDto : AbstractDto
    {
        public string indiCode;
        public string prenom;
        public string nom;

        /// <summary>
        /// Constructeur vide.
        /// </summary>        
        public IntervenantDto() : base() { }

        /// <summary>
        /// Méthode <see cref="ToString"/>.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} ({2})", this.prenom, this.nom, this.indiCode);
        }
    }
}