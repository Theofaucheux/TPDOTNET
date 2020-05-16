using Modele.Faucheux;
using Modele.Faucheux.Entities;
using System.Linq;

namespace Bussiness.TP.Commands
{
    class AbsenceCommands
    {
        public readonly Context _context;
        public AbsenceCommands(Context context)
        {
            _context = context;
        }

        public int Ajouter(Absence a)
        {
            _context.Absences.Add(a);
            return _context.SaveChanges();
        }

        public void Modifier(Absence a)
        {
            Absence uptAbs = _context.Absences.Where(abs => abs.AbsenceID == a.AbsenceID).FirstOrDefault();
            if(uptAbs != null)
            {
                uptAbs.DateAbsence = a.DateAbsence;
                uptAbs.Motif = a.Motif;
            }
            _context.SaveChanges();
        }

        public void Supprimer(int absenceID)
        {
            Absence delAbs = _context.Absences.Where(abs => abs.AbsenceID == absenceID).FirstOrDefault();
            if(delAbs != null) 
            {
                _context.Absences.Remove(delAbs);
            }
            _context.SaveChanges();
        }
    }
}
