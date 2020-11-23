using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet231120.Models
{
    class Individuel : Client
    {
        #region Attributs
        private int _coupon;
        #endregion

        #region Constructeurs
        public Individuel(int coupon)
        {
            _coupon = coupon;
        }
        #endregion

        #region Getters Setters
        public int Coupon { get => _coupon; set => _coupon = value; }
        #endregion

        #region Methodes
        #endregion
    }
}
