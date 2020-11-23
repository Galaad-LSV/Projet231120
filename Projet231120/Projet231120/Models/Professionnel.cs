using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet231120.Models
{
    class Professionnel: Client
    {
        #region Attributs
        private int _volumeNegocie;
        private int _remise;
        #endregion
        #region Constructeurs
        public Professionnel(int volumeNegocie, int remise): base()
        {
            VolumeNegocie = volumeNegocie;
            Remise = remise;
        }
        #endregion
        #region Getters-Setteurs
        public int VolumeNegocie { get => _volumeNegocie; set => _volumeNegocie = value; }
        public int Remise { get => _remise; set => _remise = value; }
        #endregion
        #region Methodes
        #endregion
    }
}
