using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modele.Faucheux.Entities
{
    [Table("Absence")]
    public class Absence
    {
        [Key]
        public int AbsenceID { get; set; }

        [Timestamp]
        [Required]
        public DateTime DateAbsence { get; set; }

        [StringLength(200)]
        [Required]
        public string Motif { get; set; }
        public int EleveID { get; set; }

        [ForeignKey("EleveID")]
        public Eleve Eleve { get; set; }
    }
}
