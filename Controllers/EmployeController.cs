using Business.Contracts;
using DesignPatternApp;
using System.Collections.Generic;

namespace Controllers
{
    public class EmployeController
    {
        private IEmployeService EmployeService { get; }

        public EmployeController(IEmployeService employeService)
        {
            EmployeService = employeService;
        }

        public Employe CreerEmploye(string prenom, string nom, double salaire)
        {
            if (salaire > 0) return EmployeService.CreerEmploye(prenom, nom, salaire);
            return null;
        }

        public List<Employe> GetListEmployes() => EmployeService.GetListEmployes();

        public Employe GetEmployeById(int id) => EmployeService.GetEmployeById(id);
    }
}
