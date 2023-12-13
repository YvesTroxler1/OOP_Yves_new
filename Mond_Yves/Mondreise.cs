using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mond_Yves
{
    public class Mondreise
    {

        private double speedKmh;
        private double distanceToMoon = 384400 ;

        public Mondreise(double speed)
        {

            speedKmh = speed;

        }

        public double GetTravelDurationDays()
        {

            double speedKmPerDay = speedKmh / 24.0;
            double timeInDays = distanceToMoon / speedKmPerDay;
            
            return timeInDays;

        }

        public double GetTravelDurationHours()
        {
            return GetTravelDurationDays() / 24;
        }


    }
}





        
    
    

    
