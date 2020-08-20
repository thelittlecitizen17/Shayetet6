using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6.MissilesCreators
{
    class CruiseCreator : IMissileCreator
    {
        public IMissile RunAction()
        {

            Cruise cruise = new Cruise();
            return cruise;   
        }
    }
}
