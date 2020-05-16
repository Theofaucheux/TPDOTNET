using Modele.Faucheux;
using Modele.Faucheux.Entities;
using System.Linq;

namespace Bussiness.TP.Commands
{
    public class ClasseCommands
    {
        public readonly Context _context;

        public ClasseCommands(Context context)
        {
            _context = context;
        }

        public int Ajouter(Classe e)
        {
            _context.Classes.Add(e);
            return _context.SaveChanges();
        }

        public void Modifier(Classe c)
        {
            Classe uptCla = _context.Classes.Where(cla => cla.ClasseID == c.ClasseID).FirstOrDefault();
            if (uptCla != null)
            {
                uptCla.Niveau = c.Niveau;
                uptCla.Niveau = c.NomEtablissement;
            }
            _context.SaveChanges();
        }

        public void Supprimer(int ClasseID)
        {
            Classe delCla = _context.Classes.Where(e => e.ClasseID == ClasseID).FirstOrDefault();
            if (delCla != null)
            {
                _context.Classes.Remove(delCla);
            }
            _context.SaveChanges();
        }
    }
}
