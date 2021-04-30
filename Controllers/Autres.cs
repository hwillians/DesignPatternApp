using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Controllers
{
    public static class Autres
    {

        public static string GetStringConsole(string messag = "Valeur ")
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

        public static double GetDoubleConsole(string messag)
        {
            double valeur;
            while (!double.TryParse(GetStringConsole(messag), out valeur))
                Write("verifiez votre saisie :");

            return valeur;
        }

        public static int GetIntConsole(string messag)
        {
            int valeur;
            while (!int.TryParse(GetStringConsole(messag), out valeur))
                Write("verifiez votre saisie :");

            return valeur;
        }


    }
}
