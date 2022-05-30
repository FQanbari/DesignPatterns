using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._04___State_Pattern.Exercises
{
    public class Driving : TravelMode
    {
        public int getDirection()
        {
            Console.WriteLine("Calculating Direction (driving)");
            return 1;
        }

        public int getEta()
        {
            Console.WriteLine("Calculating ETA (driving)");            
            return 1;
        }
    }
}
