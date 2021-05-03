using Business.Contracts;
using View;
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

        public Employe CreerEmploye(string prenom, string nom, double salaire) => EmployeService.CreerEmploye(prenom, nom, salaire);

        public List<Employe> GetListEmployes() => EmployeService.GetListEmployes();

        public Employe GetEmployeById(int id) => EmployeService.GetEmployeById(id);
    }
}
