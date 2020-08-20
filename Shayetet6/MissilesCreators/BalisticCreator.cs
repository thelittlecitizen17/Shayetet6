using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6.MissilesCreators
{
    class BalisticCreator : IMissileCreator
    {
        public IMissile RunAction()
        {

            Balistic balistic = new Balistic();
            return balistic;
        }


    }
}
