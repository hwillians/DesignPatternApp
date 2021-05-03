using Controllers;
using View;
using System;
using static System.Console;

namespace View
{
    public static class Outils
    {
        public static void Menu(EmployeController controller)
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

                        Employe employe = controller.CreerEmploye(
                            GetStringConsole("Tapez le prénom : "),
                            GetStringConsole("Tapez le nom : "),
                            GetDoubleConsole("Tapez le salaire : ")
                            );
                        WriteLine(employe != null ? employe : "Le salaire doit être supérieur à 0");
                        break;

                    case 2:
                        WriteLine(string.Join("\n", controller.GetListEmployes()));
                        break;

                    case 3:
                        int id = GetIntConsole("Tapez l'Id : ");
                        Employe employeId = controller.GetEmployeById(id);
                        WriteLine(employeId != null ? employeId : $"L'Id {id} n'est pas reconnu");
                        break;

                    case 0: WriteLine("à bientôt..."); break;

                    default: WriteLine("Action non reconnue..."); break;
                }
            }
        }


        public static string GetStringConsole(string messag = "Valeur ")
        {
            Write(messag);
            var s = ReadLine();
            while (String.IsNullOrEmpty(s))
            {
                Write("Le text ne peux etre vide : ");
                s = ReadLine();
            }
            return s;
        }

        public static double GetDoubleConsole(string messag)
        {
            double valeur;
            while (!double.TryParse(GetStringConsole(messag), out valeur))
                Write("Verifiez votre saisie : ");

            return valeur;
        }

        public static int GetIntConsole(string messag)
        {
            int valeur;
            while (!int.TryParse(GetStringConsole(messag), out valeur))
                Write("Verifiez votre saisie : ");

            return valeur;
        }

    }
}
