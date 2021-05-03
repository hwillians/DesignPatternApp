using Business.Contracts;
using DesignPatternApp;
using Repository.Contracts;
using System.Collections.Generic;

namespace Business
{
    public class EmployeService : IEmployeService
    {
        IEmployeRepository EmployeRepository { get; }

        public EmployeService(IEmployeRepository employeRepository)
        {
            EmployeRepository = employeRepository;
        }

        public Employe CreerEmploye(string prenom, string nom, double salaire) =>
            EmployeRepository.CreerEmploye(prenom, nom, salaire);


        public List<Employe> GetListEmployes() => EmployeRepository.GetListEmployes();

        public Employe GetEmployeById(int id) => EmployeRepository.GetEmployeById(id);
    }
}
