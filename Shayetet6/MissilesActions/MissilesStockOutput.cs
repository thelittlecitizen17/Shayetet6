using MenuBuilder;
using Shayetet6.MissilesCreators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6.MissilesActions
{
    class MissilesStockOutput : IAction
    {
        private MissileBattery _missileBattery;
        private Dictionary<string, IMissileCreator> _missileDictCreator;

        public MissilesStockOutput(MissileBattery missileBattery, Dictionary<string, IMissileCreator> missileDictCreator)
        {
            _missileBattery = missileBattery;
            _missileDictCreator = missileDictCreator;
        }
        public void RunOption()
        {
            var TotalNumberOfMissiles = _missileBattery.MissilesStck.Count;

            if(TotalNumberOfMissiles>0)
            {
                Console.WriteLine($"The Total number of missiles is: {TotalNumberOfMissiles}");
                Console.WriteLine("\nList of Misiiles in the stock:\n");
                foreach (var missile in _missileBattery.MissilesStck)
                {
                    Console.WriteLine(missile.MissileType);
                }
            }
            else
            {
                Console.WriteLine("\nThe missiles stock is empty");
                
            }

        }
    }
}
