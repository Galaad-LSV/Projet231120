using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet231120.Models
{
    public class Colis
    {
        #region Attributs
        private static List<Colis> collClasseColis = new List<Colis>();
        private int _id;
        private string _volume;
        #endregion

        #region Constructeur
        public Colis(int id, string volume)
        {
            _id = id;
            _volume = volume;
            collClasseColis.Add(this);
        }
        #endregion

        #region Getters-Setters
        internal static List<Colis> CollClasseColis { get => collClasseColis; set => collClasseColis = value; }
        public int Id { get => _id; set => _id = value; }
        public string Volume { get => _volume; set => _volume = value; }
        #endregion

        #region Méthodes
        #endregion

    }
}
