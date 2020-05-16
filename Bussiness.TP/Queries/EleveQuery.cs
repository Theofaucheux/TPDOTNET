using Modele.Faucheux;
using Modele.Faucheux.Entities;
using System.Linq;

namespace Bussiness.TP.Queries
{
    public class EleveQuery
    {
        private readonly Context _context;

        public EleveQuery(Context context)
        {
            _context = context;
        }

        public IQueryable<Eleve> GetAll()
        {
            return _context.Eleves;
        }

        public IQueryable<Eleve> GetById(int id)
        {
            return _context.Eleves.Where(p => p.EleveID == id);
        }
    }
}
