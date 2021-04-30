using System;
using System.Linq;
using Controllers;
using static System.Console;
using static Controllers.Autres;

namespace DesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix = -1;

            WriteLine("*** Ménu Gestion des employés ***" +
                "\n1.- Ajouter un employé" +
                "\n2.- Afficher la liste des employés" +
                "\n3.- Afficher un employé");

            while (choix != 0)
            {
                choix = GetIntConsole("\nQuelle action voulez vouz effectuer : ");

                switch (choix)
                {
                    case 1:
                        try
                        {
                            EmployeController.CreerEmployer();
                            WriteLine("L'employé à été créé avec succès.");
                        }
                        catch (Exception e)
                        {
                            WriteLine(e.Message);
                        }
                        break;
                    case 2:
                        WriteLine(String.Join("\n", LocalStorage.Instance.Employes));
                        break;
                    case 3:
                        WriteLine(EmployeController.GetEmployeById(GetIntConsole("Tapez l'Id : ")));
                        break;
                    case 0: WriteLine("à bientôt..."); break;

                    default: WriteLine("Action non reconnue..."); break;
                }
            }
        }
    }
}
