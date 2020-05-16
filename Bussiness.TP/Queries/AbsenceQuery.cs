using Modele.Faucheux;
using Modele.Faucheux.Entities;
using System.Linq;

namespace Bussiness.TP.Queries
{
    public class AbsenceQuery
    {
        private readonly Context _context;

        public AbsenceQuery(Context context)
        {
            _context = context;
        }

        public IQueryable<Absence> GetAll()
        {
            return _context.Absences;
        }

        public IQueryable<Absence> GetById(int id)
        {
            return _context.Absences.Where(p => p.AbsenceID == id);
        }
    }
}
