using Modele.Faucheux;
using Modele.Faucheux.Entities;
using System.Linq;

namespace Bussiness.TP.Queries
{
    public class NoteQuery
    {
        private readonly Context _context;

        public NoteQuery(Context context)
        {
            _context = context;
        }

        public IQueryable<Note> GetAll()
        {
            return _context.Notes;
        }

        public IQueryable<Note> GetById(int id)
        {
            return _context.Notes.Where(p => p.NoteID == id);
        }
    }
}
