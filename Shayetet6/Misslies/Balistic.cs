using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    class Balistic:IMissile
    {
        public double Successrate { get; set; }
        public string MissileType { get; set; }

        public Balistic()
        {
            Successrate = 50;
            MissileType = "Balistic";
        }
    }
}
