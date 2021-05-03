using DesignPatternApp;
using System.Collections.Generic;

namespace Repository.Contracts
{
    public interface IEmployeRepository
    {
        Employe CreerEmploye(string prenom, string nom, double salaire);
        List<Employe> GetListEmployes();
        Employe GetEmployeById(int id);
    }
}