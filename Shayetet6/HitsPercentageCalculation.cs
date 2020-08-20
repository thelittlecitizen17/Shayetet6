using Shayetet6.MissilesCreators;
using Shayetet6.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shayetet6
{
    class HitsPercentageCalculation
    {
        private Random _random = new Random();
        public HitsPercentageCalculation()
        {

        }
        public bool MissileHitTheTarget(IMissile missile)
        {
            bool LongRange = false;

            var interfaces = missile.GetType().GetInterfaces();
            foreach(var i in interfaces)
            {
                if(i.Name=="ILongRangeMissile")
                {
                    LongRange = true;
                }
            }

            if(LongRange)
            {
                return _longRangeMissileHit((ILongRangeMissile)missile);
            }
            else
            {
                return _normalMissileHit(missile);
            }


        }
        private bool _longRangeMissileHit(ILongRangeMissile missile)
        {
            var userRange = "0";
            double range = 0;
            bool successfulTarget = false;

            DoubleValidation doubleValidation = new DoubleValidation();

            while (!successfulTarget)
            {
                Console.WriteLine("\nPlease enter target's Range for Topol missile:");
                userRange = Console.ReadLine();
                if(doubleValidation.Validate(userRange))
                {
                    range = double.Parse(userRange);
                    if(range>1500 && range>0)
                    {
                        Console.WriteLine("\nThe missile cannot fly that far!!");
                    }
                    else
                    {
                        successfulTarget = true;
                    }
                }
            }

            double p = 100 - ((range / missile.Range) * 100);
            
            int perCent = _random.Next(0, 100);
            if (perCent < p)
            {
                return true;
            }

            return false;


        }
        private bool _normalMissileHit(IMissile missile)
        {
            int perCent = _random.Next(0, 100);
            if (perCent < missile.Successrate)
            {
                return true;
            }

            return false;
        }

    }
}
