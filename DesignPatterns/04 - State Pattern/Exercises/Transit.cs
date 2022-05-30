using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._04___State_Pattern.Exercises
{
    public class Transit : TravelMode
    {
        public int getDirection()
        {
            Console.WriteLine("Calculating Direction (transit)");
            return 3;
        }

        public int getEta()
        {
            Console.WriteLine("Calculating ETA (transit)");
            return 3;
        }
    }
}
