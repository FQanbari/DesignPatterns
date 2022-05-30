using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._04___State_Pattern.Exercises
{
    public class Bicyling : TravelMode
    {
        public int getDirection()
        {
            Console.WriteLine("Calculating Direction (bicycling)");
            return 2;
        }

        public int getEta()
        {
            Console.WriteLine("Calculating ETA (bicycling)");
            return 2;
        }
    }
}
