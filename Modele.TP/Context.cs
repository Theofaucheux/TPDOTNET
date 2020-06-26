using Modele.Faucheux.Entities;
using System.Data.Entity;

namespace Modele.Faucheux
{
    public class Context : DbContext
    {
        public Context() : base("name=connectionString")
        {
        }

        public DbSet<Classe> Classes { get; set; }
        public DbSet<Eleve> Eleves { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Absence> Absences { get; set; }
    }
}