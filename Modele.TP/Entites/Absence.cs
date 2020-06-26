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

        [Required]
        public DateTime DateAbsence { get; set; }

        [StringLength(200)]
        [Required]
        public string Motif { get; set; }
        public int EleveID { get; set; }

        [ForeignKey("EleveID")]
        public Eleve Eleve { get; set; }

        public Absence()
        {
        }

        public Absence(int absenceID, DateTime dateAbsence, string motif, int eleveID, Eleve eleve)
        {
            AbsenceID = absenceID;
            DateAbsence = dateAbsence;
            Motif = motif;
            EleveID = eleveID;
            Eleve = eleve;
        }
    }
}
