
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sujet07112022.Modeles
{
    internal class LigueRegionale
    {
        #region Attributs

        public static List<LigueRegionale> CollClasse = new List<LigueRegionale>();
        private int _code;
        private string _nom;
        private string _adresse;
        private string _email;


        #endregion

        #region Constructeurs

        public LigueRegionale()
        {
            LigueRegionale.CollClasse.Add(this);
        }

        public LigueRegionale(string nom, string adresse, string email)
        {
            _code = 1;
            Nom = nom;
            _adresse = adresse;
            _email = email;
        }




        #endregion

        #region Getters/Setters

        public int GetCode()
        {
            return _code;
        }

        public void SetCode( int param)
        {
            _code=param;
        }

        public string GetNom()
        {
            return _nom;
        }

        public void SetNom(string param)
        {
            _nom = param;
        }

        public string GetAdresse()
        {
            return _adresse;
        }

        public void SetAdresse(string param)
        {
            _adresse = param;
        }
        public string GetEmail()
        {
            return _email;
        }

        public void SetEmail(string param)
        {
            _email = param;
        }

        #endregion

        #region Methodes

        public int AjoutValeurCode(int param)
        {
            int resultat = 0;
            // codage pour ajouter au code de l'objet courant (this) le param et le deverser dans resultat
            resultat = this.GetCode() + param;
            return resultat;
        }

        #endregion
    }
}
