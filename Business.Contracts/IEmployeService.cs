using View;
using System.Collections.Generic;

namespace Business.Contracts
{
    public interface IEmployeService
    {
        Employe CreerEmploye(string prenom, string nom, double salaire);
        List<Employe> GetListEmployes();
        Employe GetEmployeById(int id);
    }
}
