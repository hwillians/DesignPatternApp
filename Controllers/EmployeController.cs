using DesignPatternApp;
using System.Linq;
using static Controllers.Autres;

namespace Controllers
{
    public static class EmployeController
    {
        public static void CreerEmployer()
        {
            LocalStorage.Instance.Employes.Add(new Employe
            {
                Id = GetIntConsole("Tapez l'Id : "),
                Prenom = GetStringConsole("Tapez le prénom : "),
                Nom = GetStringConsole("Tapez le nom : "),
                Salaire = GetDoubleConsole("Tapez le salaire : ")
            });
        }

        public static Employe GetEmployeById(int id)
        {
            if (LocalStorage.Instance.Employes.Any(e => e.Id == id))
                return LocalStorage.Instance.Employes.First(e => e.Id == id);

            return null;
        }
    }
}
