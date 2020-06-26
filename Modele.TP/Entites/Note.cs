using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modele.Faucheux.Entities
{
    [Table("Note")]
    public class Note
    {
        [Key]
        public int NoteID { get; set; }

        [StringLength(50)]
        [Required]
        public string Matiere { get; set; }

        [Required]
        public DateTime DateNote { get; set; }

        [StringLength(200)]
        [Required]
        public string Appreciation { get; set; }

        [Range(0, 20, ErrorMessage = "Valeur de note invalide")]
        [Required]
        public int ValNote { get; set; }
        public int EleveID { get; set; }

        [ForeignKey("EleveID")]
        public Eleve Eleve { get; set; }

        public Note()
        {
        }

        public Note(int noteID, string matiere, DateTime dateNote, string appreciation, int valNote, Eleve eleve)
        {
            NoteID = noteID;
            Matiere = matiere;
            DateNote = dateNote;
            Appreciation = appreciation;
            ValNote = valNote;
            Eleve = eleve;
        }
    }
}