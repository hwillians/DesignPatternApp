using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp
{
    public class Employe
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public string Prenom { get; set; }
        private double salaire;

        public double Salaire
        {
            get { return salaire; }
            set
            {
                if (value > 0) salaire = value;
                else throw new Exception("Le salaire doit être supérieur à 0");
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} salaire : {2}",Prenom,Nom.ToUpper(),Salaire);
        }
    }
}
