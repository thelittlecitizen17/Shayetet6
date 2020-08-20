using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    class Torpedo:IMissile
    {
        public double Successrate { get; set; }
        public string MissileType { get; set; }

        public Torpedo()
        {
            MissileType = "Torpedo";
            Successrate = 100;
        }
    }
}
