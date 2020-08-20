using MenuBuilder;
using Shayetet6.MissilesCreators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6.MissilesActions
{
    class LunchMissiles : IAction
    {
        private MissileBattery _missileBattery;
        private Dictionary<string, IMissileCreator> _missileDictCreator;
        private HitsPercentageCalculation _hits = new HitsPercentageCalculation();
        private List<string> _menuOptions = new List<string>();

        public LunchMissiles(MissileBattery missileBattery, Dictionary<string, IMissileCreator> missileDictCreator, List<string> menuOptions)
        {
            _missileBattery = missileBattery;
            _missileDictCreator = missileDictCreator;
            _menuOptions = menuOptions;

        }
        public void RunOption()
        {
            int count = 0;
            int hitsCount = 0;

            MissilesMenu missilesMenu = new MissilesMenu(_menuOptions);

            var missile = missilesMenu.MenuOutput();

            if (missile == "TotalWar")
            {
                foreach (var m in _missileBattery.MissilesStck.ToArray())
                {
                    if (_hits.MissileHitTheTarget(m))
                    {
                        hitsCount++;
                    }
                    _missileBattery.MissileLancher(m);
                    count++;


                }
            }
            else
            {
                IntValidator doubleValidator = new IntValidator();
                bool canParse = false;
                string userChoice = "0";

                while (!canParse)
                {
                    Console.Write("Please enter the number of missiles you want to lunch: ");
                    userChoice = Console.ReadLine();
                    canParse = doubleValidator.Validate(userChoice);
                    if (!canParse)
                    {
                        Console.WriteLine("\nThe number you entered invalid!\n ");
                    }
                }

                int numberOfMissiles = int.Parse(userChoice);

                if (numberOfMissiles <= _missileBattery.MissilesStck.Count)
                {
                    for (int i = 0; i < _missileBattery.MissilesStck.Count && count < numberOfMissiles; i++)
                    {
                        if (missile == _missileBattery.MissilesStck[i].MissileType)
                        {
                            if (_hits.MissileHitTheTarget(_missileBattery.MissilesStck[i]))
                            {
                                hitsCount++;
                            }
                            _missileBattery.MissileLancher(_missileBattery.MissilesStck[i]);
                            count++;
                            i--;

                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nYou want to lunch more than you have!\n");
                    return;
                }
            }
            Console.WriteLine($"\n{count} missiles were launched and {hitsCount} hit the target\n");
        }


    }
}
