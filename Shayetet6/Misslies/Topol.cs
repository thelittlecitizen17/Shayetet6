using Shayetet6.MissilesCreators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6.Misslies
{
    class Topol : ILongRangeMissile
    {
        public double Successrate { get ; set; }
        public string MissileType { get; set; }
        public double Range { get ; set; }

        public Topol()
        {
            MissileType = "Topol";
            Range = 1500;

        }

    }
}
