using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6.MissilesCreators
{
    interface ILongRangeMissile:IMissile
    {
        double Range { get; set; }
    }
}
