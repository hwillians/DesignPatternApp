using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternApp
{
    public sealed class LocalStorage
    {
        private static LocalStorage instance = null;
        public List<Employe> Employes { get; set; } = new()
        {
            new Employe { Id = 1, Prenom = "Fulano", Nom = "De tal", Salaire = 1600.00 },
            new Employe { Id = 2, Prenom = "Zutano", Nom = "Goméz", Salaire = 2000.00 },
            new Employe { Id = 3, Prenom = "Perenzejo", Nom = "Pérez", Salaire = 4000.00 },
        };

        private LocalStorage() { }

        public static LocalStorage Instance
        {
            get
            {
                if (instance == null) instance = new LocalStorage();
                return instance;
            }
        }
    }
}
