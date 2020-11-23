﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet231120.Models
{
    class Compartiment
    {
        #region Attributs
        private static List<Compartiment> collClassCompartiment = new List<Compartiment>();

        private int _positionX;
        private int _positionY;
        private Box _leBox;
        #endregion

        #region Constructeur
        public Compartiment(int positionX, int positionY, Box leBox)
        {
            this._positionY = positionY;
            this._positionX = positionX;
            _leBox = leBox;
        }
        #endregion

        #region Get-Set
        public static List<Compartiment> CollClassCompartiment { get => collClassCompartiment; set => collClassCompartiment = value; }
        public int PositionX { get => _positionX; set => _positionX = value; }
        public int PositionY { get => _positionY; set => _positionY = value; }
        #endregion

        #region Methode
        #endregion

    }
}
