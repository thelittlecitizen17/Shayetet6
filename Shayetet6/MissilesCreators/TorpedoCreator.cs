using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;

namespace Shayetet6.MissilesCreators
{
    class TorpedoCreator : IMissileCreator
    {
        public IMissile RunAction()
        {

            Torpedo torpedo = new Torpedo();
            return torpedo;

        }

    }

}
