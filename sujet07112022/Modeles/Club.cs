using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sujet07112022.Modeles
{
    internal class Club
    {
        #region Attributs

        private int _id;
        private string _nom ;
        private string _adresse ;
        private string _email;
        private LigueRegionale _laLigueRegionale;
        private List<Licence> _lesLicences;
        public static List<Club> CollClasse = new List<Club>();

        #endregion

        #region Constructeurs

        public Club()
        {
            _lesLicences = new List<Licence>();
            Club.CollClasse.Add(this);
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
        public LigueRegionale GetLaLigueRegionale()
        {
            return _laLigueRegionale;
        }
        public void SetLaLigueRegionale(LigueRegionale param)
        {
            _laLigueRegionale = param;
        }
        #endregion

        #region Methodes
        public void AjouterALaLigue(LigueRegionale param)
        {
            param.AjouterClub(this);
        }
        #endregion
    }
}
