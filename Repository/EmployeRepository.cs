using DesignPatternApp;
using Repository.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class EmployeRepository : IEmployeRepository
    {
        public Employe CreerEmploye(string prenom, string nom, double salaire)
        {
            Employe employe = new()
            {
                Id = LocalStorage.Instance.Employes.Count + 1,
                Prenom = prenom,
                Nom = nom,
                Salaire = salaire
            };
            LocalStorage.Instance.Employes.Add(employe);
            return employe;
        }

        public Employe GetEmployeById(int id)
        {
            if (LocalStorage.Instance.Employes.Any(e => e.Id == id))
                return LocalStorage.Instance.Employes.First(e => e.Id == id);

            return null;
        }

        public List<Employe> GetListEmployes() => LocalStorage.Instance.Employes;
    }
}
