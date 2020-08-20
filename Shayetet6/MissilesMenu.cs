using Shayetet6.MissilesCreators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{


    class MissilesMenu
    {
        List<string> _menuOptions;
        public MissilesMenu(List<string> menuOptions)
        {
            _menuOptions = menuOptions;
        }
        public string MenuOutput()
        {
            while (true)
            {
                foreach (var option in _menuOptions)
                {
                    Console.WriteLine("\n" + option);
                }

                Console.WriteLine("\nPlease enter your choice: ");
                var choice = Console.ReadLine();

                if(_menuOptions.Contains(choice))
                {
                    return choice;
                }
                
                else
                {
                    Console.WriteLine("\nThere is no such option in the menu! Please try again\n");
                }
            }
        }
    }
}
