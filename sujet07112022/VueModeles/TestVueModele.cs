using sujet07112022.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sujet07112022.VueModeles
{
    internal class TestVueModele
    {
        public TestVueModele()
        {
            LigueRegionale L1 = new LigueRegionale();
            // J'envoie 10 et riri dans les attributs de L1
            L1.SetCode(10);
            L1.Nom = "riri";
            //recuperer le code de l'objet L1 ainsi que le nom;
            int resultat =  L1.GetCode();
            string resultat2 = L1.Nom;
        }
    }
}
