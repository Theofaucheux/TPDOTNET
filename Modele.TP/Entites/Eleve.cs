using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modele.Faucheux.Entities
{
    [Table("Eleve")]
    public class Eleve
    {
        [Key]
        public int EleveID { get; set; }

        [StringLength(50)]
        [Required]
        public string Nom { get; set; }

        [StringLength(50)]
        [Required]
        public string Prenom { get; set; }

        [Timestamp]
        [Required]
        public DateTime DateNaissance { get; set; }

        public int ClasseID { get; set; }

        [ForeignKey("ClasseID")]
        public Classe Classe { get; set; }
    }
}