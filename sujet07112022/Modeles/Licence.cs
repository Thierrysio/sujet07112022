using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sujet07112022.Modeles
{
    internal class Licence
    {
        #region Attributs

        private int _numero;
        private int _annee;
        private Club _leClub;

        public static List<Licence> CollClasse = new List<Licence>();

        #endregion

        #region Constructeurs

        public Licence()
        {
            Licence.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        public int GetNumero()
        {
            return _numero;
        }

        public void SetNumero(int param)
        {
            _numero = param;
        }
        public int GetAnnee()
        {
            return _annee;
        }

        public void SetAnnee(int param)
        {
            _annee = param;
        }
        public Club GetLeClub()
        {
            return _leClub;
        }

        public void SetLeClub(Club param)
        {
            _leClub = param;
        }
        #endregion

        #region Methodes

        #endregion
    }
}
