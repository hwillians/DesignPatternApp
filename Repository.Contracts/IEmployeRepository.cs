using DesignPatternApp;
using System.Collections.Generic;

namespace Repository.Contracts
{
    public interface IEmployeRepository
    {
        Employe CreerEmploye(Employe employe);
        List<Employe> GetListEmployes();
        Employe GetEmployeById(int id);
    }
}