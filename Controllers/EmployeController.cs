using System.Linq;
using DesignPatternApp;

namespace Controllers
{
    public static class EmployeController
    {
        public static void CreerEmployer(Employe employe)
        {
            LocalStorage.Instance.Employes.Add(employe);
        }

        public static Employe GetEmployeById(int id)
        {
            if (LocalStorage.Instance.Employes.Any(e => e.Id == id))
                return LocalStorage.Instance.Employes.First(e => e.Id == id);

            return null;
        }
    }
}
