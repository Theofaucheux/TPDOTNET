using System;
using System.Linq;
using Bussiness.TP.Commands;
using Bussiness.TP.Queries;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modele.Faucheux;
using Modele.Faucheux.Entities;

namespace Test.TP.TestModels
{
    [TestClass]
    public class ClasseTests
    {
        private Context _context;
        private ClasseCommands com;
        private ClasseQuery query;

        public ClasseTests()
        {
            _context = new Context();
            com = new ClasseCommands(_context);
            query = new ClasseQuery(_context);
        }

        [TestMethod]
        public void TestAddClasse()
        {
            Classe c = new Classe { Niveau = "CE1", NomEtablissement = "Jul" };

            com.Ajouter(c);
            Classe nc = _context.Classes.FirstOrDefault(e => e.NomEtablissement == "Jul" && e.Niveau == "CE1");

            Assert.IsTrue(nc.Niveau == c.Niveau);
            Assert.IsTrue(nc.NomEtablissement == c.NomEtablissement);
        }

        [TestMethod]
        public void TestUpdateClasse()
        {
            Classe c = query.GetById(1).First();
            string nom = c.NomEtablissement;
            string nnom = "La Zone en personne";
            c.NomEtablissement = nnom;

            com.Modifier(c);
            Classe nc = query.GetById(1).First();

            Assert.IsTrue(nc.NomEtablissement == c.NomEtablissement);
        }

        [TestMethod]
        public void TestDeleteClasse()
        {
            Classe c = new Classe { NomEtablissement = "K-Maro", Niveau = "Sport" };
            _context.Classes.Add(c);
            _context.SaveChanges();

            Classe nc = _context.Classes.FirstOrDefault(e => e.NomEtablissement == "K-Maro" && e.Niveau == "Sport");

            com.Supprimer(nc.ClasseID);

            Assert.IsNull(_context.Classes.FirstOrDefault(e => e.NomEtablissement == "K-Maro" && e.Niveau == "Sport"));
        }
    }
}
