using Projet231120.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet231120.Utilitaires
{
    class Conversion
    {
        public static float ConversionStringEnFloat(string p)
        {
            return float.Parse(p);            
        }

        public static string ConversionIntEnString(int p)
        {
            return p.ToString();
        }

    }
}
