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
        private int _id;
        private string _libelle;
        private int _ageMin;
        private int _ageMax;
        private List<Licence> _lesLicences;
        public static List<Categorie> CollClasse = new List<Categorie>();

        #endregion

        #region Constructeurs

        public Categorie()
        {
            Categorie.CollClasse.Add(this);
        }

        #endregion

        #region Getters/Setters
        public int GetId()
        {
            return _id;
        }

        public void SetId(int param)
        {
            _id = param;
        }

        public string GetLibelle()
        {
            return _libelle;
        }

        public void SetLibelle(string param)
        {
            _libelle = param;
        }
        public int GetAgeMin()
        {
            return _ageMin;
        }

        public void SetAgeMin(int param)
        {
            _ageMax = param;
        }
        public int GetAgeMax()
        {
            return _ageMax;
        }

        public void SetAgeMax(int param)
        {
            _ageMax = param;
        }
        public List<Licence> GetLesLicences()
        {
            return _lesLicences;
        }

        public void SetLesLicences(List<Licence> param)
        {
            _lesLicences = param;
        }
        #endregion

        #region Methodes
        public List<LigueRegionale> GetListeLigues()
        {
            List<LigueRegionale> resultat = new List<LigueRegionale>();

            foreach(Licence uneLicence in this.GetLesLicences())
            {
                if (!resultat.Contains(uneLicence.GetLeClub().GetLaLigueRegionale()))
                {
                    resultat.Add(uneLicence.GetLeClub().GetLaLigueRegionale());
                }

            }
            return resultat;
        }
        #endregion
    }
}
