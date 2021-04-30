using System;
using static System.Console;

namespace DesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalStorage localStorage = LocalStorage.Instance;
            var employes = localStorage.Employes;

            int choix = -1;
            WriteLine("*** Ménu Gestion des employés ***" +
                "\n1.- Ajouter un employé" +
                "\n2.- Afficher la liste des employés" +
                "\n3.- Afficher un employé" +
                "\n Quelle action voulez vouz effectuer ? : ");

            while (choix != 0)
            {
                choix = GetIntConsole("Quelle action voulez vouz effectuer ? ");

                switch (choix)
                {
                    case 1:
                        var employe = new Employe
                        {
                            Id = GetIntConsole("tapez l'Id"),
                            Prenom = getStringConsole("Tapez le prénom : "),
                            Nom = getStringConsole("Tapez le Nom : "),
                        };
                        try
                        {
                            employe.Salaire = GetDoubleConsole("Tapez le salaire");
                            employes.Add(employe);
                            WriteLine(employe);
                        }
                        catch (Exception e)
                        {
                            WriteLine(e.Message);
                        }
                        break;
                    case 2:
                        foreach (var e in employes) WriteLine(e);
                        break;
                    case 3: WriteLine("afficher un employé"); break;
                    case 0: WriteLine("à bientôt..."); break;
                    default:
                        break;
                }
            }
            //Ajouter un employé en rentrant ses informations
            //Afficher la liste des employés
            //Afficher un employé en rentrant son Id

        }

        static string getStringConsole(string messag = "Valeur ")
        {
            WriteLine(messag);
            var s = ReadLine();
            while (String.IsNullOrEmpty(s))
            {
                WriteLine("Le text ne peux etre vide :");
                s = ReadLine();
            }
            return s;
        }

        static double GetDoubleConsole(string messag)
        {
            double valeur;
            while (!double.TryParse(getStringConsole(messag), out valeur))
                WriteLine("verifiez votre saisie :");

            return valeur;
        }

        static int GetIntConsole(string messag)
        {
            int valeur;
            while (!int.TryParse(getStringConsole(messag), out valeur))
                WriteLine("verifiez votre saisie :");

            return valeur;
        }

    }
}
