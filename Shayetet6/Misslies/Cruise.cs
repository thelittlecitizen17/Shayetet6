using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    class Cruise:IMissile
    {
       public  double Successrate { get; set; }
       public string MissileType { get; set; }

        public Cruise()
        {
            Successrate = 20;
            MissileType = "Cruise";
        }
    }
}
