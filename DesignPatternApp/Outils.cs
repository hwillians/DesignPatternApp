using Controllers;
using DesignPatternApp;
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
                        try
                        {
                            Employe employe = controller.CreerEmploye(
                                new Employe
                                {
                                    Prenom = GetStringConsole("Tapez le prénom : "),
                                    Nom = GetStringConsole("Tapez le nom : "),
                                    Salaire = GetDoubleConsole("Tapez le salaire : ")
                                });
                            WriteLine(employe);
                        }
                        catch (Exception e)
                        {
                            WriteLine(e.Message);
                        }
                        break;

                    case 2:
                        WriteLine(string.Join("\n", controller.GetListEmployes()));
                        break;

                    case 3:
                        WriteLine(controller.GetEmployeById(GetIntConsole("Tapez l'Id : ")));
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
