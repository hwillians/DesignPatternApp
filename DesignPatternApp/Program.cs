using System;
using System.Linq;
using static System.Console;

namespace DesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employes = LocalStorage.Instance.Employes;
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
                            var employe = new Employe
                            {
                                Id = GetIntConsole("Tapez l'Id"),
                                Prenom = GetStringConsole("Tapez le prénom : "),
                                Nom = GetStringConsole("Tapez le nom : "),
                                Salaire = GetDoubleConsole("Tapez le salaire")
                            };
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
                    case 3:
                        var id = GetIntConsole("Tapez l'Id : ");

                        WriteLine(employes.Any(e => e.Id == id) ? employes.First(e => e.Id == id) : $"L'Id {id} n'est pas reconnu");
                        break;
                    case 0: WriteLine("à bientôt..."); break;

                    default: WriteLine("Action non reconnue..."); break;
                }
            }
        }

        static string GetStringConsole(string messag = "Valeur ")
        {
            Write(messag);
            var s = ReadLine();
            while (String.IsNullOrEmpty(s))
            {
                Write("Le text ne peux etre vide :");
                s = ReadLine();
            }
            return s;
        }

        static double GetDoubleConsole(string messag)
        {
            double valeur;
            while (!double.TryParse(GetStringConsole(messag), out valeur))
                Write("verifiez votre saisie :");

            return valeur;
        }

        static int GetIntConsole(string messag)
        {
            int valeur;
            while (!int.TryParse(GetStringConsole(messag), out valeur))
                Write("verifiez votre saisie :");

            return valeur;
        }

    }
}
