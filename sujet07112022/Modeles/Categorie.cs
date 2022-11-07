using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sujet07112022.Modeles
{
    internal class Categorie
    {
        #region Attributs

        public static List<Categorie> CollClasse = new List<Categorie>();

        #endregion

        #region Constructeurs

        public Categorie()
        {
            Categorie.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters

        #endregion

        #region Methodes

        #endregion
    }
}
