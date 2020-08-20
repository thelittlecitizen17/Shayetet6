using Shayetet6.Misslies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6.MissilesCreators
{
    class TopolCreator : IMissileCreator
    {
        public IMissile RunAction()
        {

            Topol topol = new Topol();
            return topol;
        }
    }
}
