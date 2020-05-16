using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modele.Faucheux;
using Modele.Faucheux.Entities;

namespace Test.TP.TestModels
{
    [TestClass]
    public class ClasseTests
    {
        private Context _context;        

        [TestMethod]
        public void TestAddClasse()
        {
            _context = new Context();
            Classe c = new Classe() { Niveau = "CP", NomEtablissement = "Ecole Jul" };
            _context.Classes.Add(c);
            _context.SaveChanges();
            Classe nc = _context.Classes.FirstOrDefault(classe => classe.NomEtablissement == "Ecole Jul" && classe.NomEtablissement == "CP");
            Assert.IsTrue(nc.Niveau == c.Niveau);
            Assert.IsTrue(nc.NomEtablissement == c.NomEtablissement);
        }
    }
}
