using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modele.Faucheux.Entities
{
    [Table("Classe")]
    public class Classe
    {
        [Key]
        public int ClasseID { get; set; }

        [StringLength(50)]
        [Required]
        public string NomEtablissement { get; set; }

        [StringLength(5)]
        [Required]
        public string Niveau { get; set; }

        public Classe()
        {
        }

        public Classe(int ClasseID, string NomEtablissement, string Niveau)
        {
            this.ClasseID = ClasseID;
            this.NomEtablissement = NomEtablissement;
            this.Niveau = Niveau;
        }
    }
}