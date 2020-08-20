using MenuBuilder;
using Shayetet6.MissilesCreators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6.MissilesActions
{
    enum MissilesNames
    {
        Torpedo,
        Cruise,
        Balistic
    }
    class AddNewMissiles : IAction
    {
        private MissileBattery _missileBattery;
        private Dictionary<string, IMissileCreator> _missileDictCreator;
        private List<string> _menuOptions = new List<string>();

        public AddNewMissiles(MissileBattery missileBattery, Dictionary<string, IMissileCreator> missileDictCreator, List<string> menuOptions)
        {
            _missileBattery = missileBattery;
            _missileDictCreator = missileDictCreator;
            _menuOptions = menuOptions;
        }
        public void RunOption()
        {
            
            MissilesMenu missilesMenu = new MissilesMenu(_menuOptions);
            var userChoice = missilesMenu.MenuOutput();

            var missile = _missileDictCreator[userChoice].RunAction();

            

            _missileBattery.AddNewMissile(missile);

        }

    }
}


