using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;
using Shayetet6.MissilesActions;
using Shayetet6.MissilesCreators;

namespace Shayetet6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myOptions = new List<string>() { "1) Adding missiles to the reservior","2) Lunch Missile","3) Print the stock status","4) Emptying the missile inventory","5) Exit"};
            string menuName = "Main Misslie";

            MissileBattery missileBattery = new MissileBattery();

            TorpedoCreator torpedoCreator = new TorpedoCreator();
            CruiseCreator cruiseCreator = new CruiseCreator();
            BalisticCreator balisticCreator = new BalisticCreator();
            TopolCreator topolCreator = new TopolCreator();
            Dictionary<string, IMissileCreator> missileDictCreator = new Dictionary<string, IMissileCreator>() { { "Torpedo", torpedoCreator }, { "Cruise", cruiseCreator }, { "Balistic", balisticCreator } ,{"Topol", topolCreator } };

            List<string> LunchMenuOptions = new List<string>() { "Please write your choice: \n", "Balistic", "Cruise", "Torpedo", "TotalWar","Topol" };
            List<string> AddMenuOptions = new List<string>() { "Please write your choice: \n", "Balistic", "Cruise", "Torpedo","Topol" };


            AddNewMissiles addMissiles = new AddNewMissiles(missileBattery , missileDictCreator,AddMenuOptions);
            DeleteMissiles outOfStock = new DeleteMissiles(missileBattery, missileDictCreator);
            LunchMissiles missileLuncher = new LunchMissiles(missileBattery, missileDictCreator, LunchMenuOptions);
            MissilesStockOutput missileStockOutput = new MissilesStockOutput(missileBattery, missileDictCreator);
            Exit exit = new Exit();

            Dictionary<string,IAction> dictOptions = new Dictionary<string, IAction>()
            {
                {"1",addMissiles},
                {"2",missileLuncher},
                {"3",missileStockOutput},
                {"4",outOfStock},
                {"5",exit}

            };



            IMenu mainMenu = new NumericMenu(myOptions, menuName, dictOptions);
            mainMenu.GetOptionFromMenu();
        }
    }
}
