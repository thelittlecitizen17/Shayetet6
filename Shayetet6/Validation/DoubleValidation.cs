using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6.Validation
{
    class DoubleValidation
    {
        public DoubleValidation()
        {

        }
        public bool Validate(string n)
        {
            double number = 0;
            bool canParse;

            canParse = double.TryParse(n, out number);

            if (canParse)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
