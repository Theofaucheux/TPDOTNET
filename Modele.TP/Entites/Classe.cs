using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ICollection<Eleve> lEleve { get; set; }

        public Classe()
        {
            lEleve = new List<Eleve>();
        }

        public Classe(int ClasseID, string NomEtablissement, string Niveau, List<Eleve> lEleve)
        {
            this.ClasseID = ClasseID;
            this.NomEtablissement = NomEtablissement;
            this.Niveau = Niveau;
            this.lEleve = new List<Eleve>(lEleve);
        }
    }
}