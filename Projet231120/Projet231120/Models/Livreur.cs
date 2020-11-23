using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet231120.Models
{
    class Livreur
    {
        #region Attributs
        public static List<Livreur> collClasseLivreur = new List<Livreur>();
        private int _idLivreur;
        private string _nomLivreur;
        private string _prenomLivreur;


        #endregion
        #region Constructeurs
        public Livreur(int idLivreur, string nomLivreur, string prenomLivreur)
        {
            IdLivreur = idLivreur;
            NomLivreur = nomLivreur;
            PrenomLivreur = prenomLivreur;
            Livreur.collClasseLivreur.Add(this);
        }


        #endregion
        #region Getter-setter
        public int IdLivreur { get => _idLivreur; set => _idLivreur = value; }
        public string NomLivreur { get => _nomLivreur; set => _nomLivreur = value; }
        public string PrenomLivreur { get => _prenomLivreur; set => _prenomLivreur = value; }
        #endregion
        #region Méthodes
        #endregion
    }
}
