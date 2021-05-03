using DesignPatternApp;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MockStorage : IEmployeRepository
    {
        public Employe CreerEmploye(string prenom, string nom, double salaire)
        {
            throw new NotImplementedException();
        }

        public Employe GetEmployeById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employe> GetListEmployes()
        {
            return new List<Employe> {
                new Employe { Id = 1, Prenom = "pTest2", Nom = "pNom1", Salaire = 1000 },
                new Employe { Id = 2, Prenom = "pTest2", Nom = "pNom2", Salaire = 2000 }
            };
        }
    }
}
