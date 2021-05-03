using DesignPatternApp;
using System.Collections.Generic;

namespace Business.Contracts
{
    public interface IEmployeService
    {
        Employe CreerEmploye(Employe employe);
        List<Employe> GetListEmployes();
        Employe GetEmployeById(int id);
    }
}
