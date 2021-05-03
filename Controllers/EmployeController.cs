using DesignPatternApp;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public static class EmployeController
    {
        public static Employe CreerEmploye(Employe employe)
        {
            employe.Id = LocalStorage.Instance.Employes.Count + 1;
            LocalStorage.Instance.Employes.Add(employe);
            return employe;
        }

        public static List<Employe> GetListEmployes() => LocalStorage.Instance.Employes;
        
        public static Employe GetEmployeById(int id)
        {
            if (LocalStorage.Instance.Employes.Any(e => e.Id == id))
                return LocalStorage.Instance.Employes.First(e => e.Id == id);

            return null;
        }
    }
}
