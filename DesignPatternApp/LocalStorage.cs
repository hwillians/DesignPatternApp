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

        public List<Employe> Employes = new() { };

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
