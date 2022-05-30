using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._04___State_Pattern.Exercises
{
    public class Walking : TravelMode
    {
        public int getDirection()
        {
            Console.WriteLine("Calculating Direction (walking)");
            return 4;
        }

        public int getEta()
        {
            Console.WriteLine("Calculating ETA (walking)");
            return 4;
        }
    }
}
