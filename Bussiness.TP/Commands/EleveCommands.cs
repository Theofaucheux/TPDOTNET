using Modele.Faucheux;
using Modele.Faucheux.Entities;
using System.Linq;

namespace Bussiness.TP.Commands
{
    class EleveCommands
    {
        public readonly Context _context;

        public EleveCommands(Context context)
        {
            _context = context;
        }

        public int Ajouter(Eleve e)
        {
            _context.Eleves.Add(e);
            return _context.SaveChanges();
        }

        public void Modifier(Eleve e)
        {
            Eleve uptEle = _context.Eleves.Where(ele => ele.EleveID == e.EleveID).FirstOrDefault();
            if(uptEle != null)
            {
                uptEle.Nom = e.Nom;
                uptEle.Prenom = e.Prenom;
                uptEle.DateNaissance = e.DateNaissance;
            }
            _context.SaveChanges();
        }

        public void Supprimer(int EleveID)
        {
            Eleve delEle = _context.Eleves.Where(e => e.EleveID == EleveID).FirstOrDefault();
            if(delEle != null)
            {
                _context.Eleves.Remove(delEle);
            }
            _context.SaveChanges();
        }
    }
}
