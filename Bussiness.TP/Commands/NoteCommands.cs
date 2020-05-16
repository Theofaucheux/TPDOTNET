using Modele.Faucheux;
using Modele.Faucheux.Entities;
using System.Linq;

namespace Bussiness.TP.Commands
{
    class NoteCommands
    {
        public readonly Context _context;

        public NoteCommands(Context context)
        {
            _context = context;
        }

        public int Ajouter(Note n)
        {
            _context.Notes.Add(n);
            return _context.SaveChanges();
        }

        public void Modifier(Note n)
        {
            Note uptNot = _context.Notes.Where(not => not.NoteID == n.NoteID).FirstOrDefault();
            if (uptNot != null)
            {
                uptNot.Matiere = n.Matiere;
                uptNot.ValNote = n.ValNote;
                uptNot.DateNote = n.DateNote;
                uptNot.Appreciation = n.Appreciation;
            }
            _context.SaveChanges();
        }

        public void Supprimer(int EleveID)
        {
            Note delNot = _context.Notes.Where(n => n.EleveID == EleveID).FirstOrDefault();
            if (delNot != null)
            {
                _context.Notes.Remove(delNot);
            }
            _context.SaveChanges();
        }
    }
}
