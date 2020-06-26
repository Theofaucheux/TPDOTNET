using System;
using System.Collections.Generic;
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

        [Required]
        public DateTime DateNaissance { get; set; }

        public int ClasseID { get; set; }

        [ForeignKey("ClasseID")]
        public Classe Classe { get; set; }

        public ICollection<Absence> lAbsence { get; set; }

        public ICollection<Note> lNote { get; set; }

        public Eleve()
        {
            lAbsence = new List<Absence>();
            lNote = new List<Note>();
        }

        public Eleve(int eleveID, string nom, string prenom, DateTime dateNaissance, Classe classe, ICollection<Absence> lAbsence, ICollection<Note> lNote)
        {
            EleveID = eleveID;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Classe = classe;
            this.lAbsence = lAbsence;
            this.lNote = lNote;
        }
    }
}