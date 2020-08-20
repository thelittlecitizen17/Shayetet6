using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    enum Missiles
    {
        Torpedo,
        Cruise,
        Balistic
    }
    class MissileBattery
    {
        public List<IMissile> MissilesStck = new List<IMissile>();

        
        public void MissileLancher(IMissile missile)
        {
            MissilesStck.Remove(missile);
        }
        public void AddNewMissile(IMissile missile)
        {
            MissilesStck.Add(missile);
        }
    }
}
