using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._04___State_Pattern.Exercises
{
    public class DirectionService
    {
        private TravelMode travelMode; 
        public DirectionService(TravelMode travelMode)
        {
            this.travelMode = travelMode;
        }

        public int getEta()
        {
            return travelMode.getEta();
        }

        public int getDirection()
        {
            return travelMode.getDirection();
        }

        public TravelMode getTravelMode()
        {
            return travelMode;
        }

        public void setTravelMode(TravelMode travel)
        {
            this.travelMode = travel;
        }
    }

}
