using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet231120.Utilitaires
{
    class GestionCollection
    {
        public static int GetNouvelIndexBox()
        {
            return Models.Box.collClasseBox.Count + 1;
        }
    }
}
