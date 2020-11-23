using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet231120.Models
{
    public class Ville
    {
        #region Attributs
        public static List<Ville> CollClassesVille = new List<Ville>();
        private int _id;
        private string _nom;
        private int _codePostal;
        private List<Box> _lesBox;
        #endregion
        #region Constructeurs
        public Ville(int id, string nom, int codePostal)
        {
            _id = id;
            _nom = nom;
            _codePostal = codePostal;
            _lesBox = new List<Box>();
            CollClassesVille.Add(this);
        }
        #endregion
        #region Getters-Setteurs
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public int CodePostal { get => _codePostal; set => _codePostal = value; }
        public List<Box> LesBox { get => _lesBox; set => _lesBox = value; }
        #endregion
        #region Methodes
        public List<Box> GetAllBox()
        {
            //retourne la liste des box dans une ville
            List<Box> uneListe = new List<Box>();
            foreach (Box unBox in this._lesBox)
            {
                uneListe.Add(unBox);
            }

            return uneListe;
        }
        #endregion
    }
}
