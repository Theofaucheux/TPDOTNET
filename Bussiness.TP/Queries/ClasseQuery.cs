using Modele.Faucheux;
using Modele.Faucheux.Entities;
using System.Linq;

namespace Bussiness.TP.Queries
{
    public class ClasseQuery
    {
        private readonly Context _context;

        public ClasseQuery(Context context)
        {
            _context = context;
        }

        public IQueryable<Classe> GetAll()
        {
            return _context.Classes;
        }

        public IQueryable<Classe> GetById(int id)
        {
            return _context.Classes.Where(p => p.ClasseID == id);
        }
    }
}
