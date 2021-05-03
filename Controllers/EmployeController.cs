using Business.Contracts;
using DesignPatternApp;
using System.Collections.Generic;

namespace Controllers
{
    public class EmployeController
    {
        private IEmployeService EmployeService { get; }

        public EmployeController(IEmployeService employeService) => EmployeService = employeService;

        public Employe CreerEmploye(Employe employe) => EmployeService.CreerEmploye(employe);

        public List<Employe> GetListEmployes() => EmployeService.GetListEmployes();

        public Employe GetEmployeById(int id) => EmployeService.GetEmployeById(id);
    }
}
