namespace GenModeDegrade.Base
{
    /// <summary>
    /// Classe parente des DTO utilisés pour récupérer les données des chapitres.
    /// </summary>
    public abstract class AbstractDto
    {
        // Code de l'individu auquel les données sont liées
        // Code utilisé pour l'extraction des données
        public string indiCodeExtraction;

        /// <summary>
        /// Constructeur vide.
        /// </summary>
        public AbstractDto()
        {
            this.indiCodeExtraction = string.Empty;
        }
    }
}