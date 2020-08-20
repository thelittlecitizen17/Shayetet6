using MenuBuilder;
using Shayetet6.MissilesCreators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6.MissilesActions
{
    class DeleteMissiles : IAction
    {
        private MissileBattery _missileBattery;
        private Dictionary<string, IMissileCreator> _missileDictCreator;
        public DeleteMissiles(MissileBattery missileBattery, Dictionary<string, IMissileCreator> missileDictCreator)
        {
            _missileBattery = missileBattery;
            _missileDictCreator = missileDictCreator;
        }
        public void RunOption()
        {
            IntValidator doubleValidator = new IntValidator();
            
            if (_missileBattery.MissilesStck.Count > 0)
            {
                bool canParse = false;
                var userMissilesPlace = "0";

                while (!canParse)
                {
                    Console.WriteLine("\nPlease enter the place of the missile you want to throw away: ");
                    userMissilesPlace = Console.ReadLine();
                    canParse = doubleValidator.Validate(userMissilesPlace);
                    if(!canParse)
                    {
                        Console.WriteLine("You entered invalid number!");
                    }
                }
                int missilePlace = int.Parse(userMissilesPlace);
                if (missilePlace - 1 <= _missileBattery.MissilesStck.Count)
                {
                    _missileBattery.MissilesStck.RemoveAt(missilePlace - 1);
                }
                else
                {
                    Console.WriteLine("\nThe number you entered is out of range\n");
                }

                
            }
            else
            {
                Console.WriteLine("The Missiles stock is empty! ");
            }
        }
    }
}
