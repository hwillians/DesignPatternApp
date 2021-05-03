using Business;
using Business.Contracts;
using Controllers;
using Repository;
using Repository.Contracts;
using Unity;
using static View.Outils;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IEmployeService, EmployeService>();
            unityContainer.RegisterType<IEmployeRepository, EmployeRepository>();
            unityContainer.RegisterType<EmployeController, EmployeController>();

            var employeController = unityContainer.Resolve<EmployeController>();

            Menu(employeController);
        }
    }
}
