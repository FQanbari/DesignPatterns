using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._04___State_Pattern.abuse
{
    public class Stopwatch
    {
        private State currentState;
        public void click()
        {
            currentState.click();
        }
        public State getCurrentTool()
        {
            return currentState;
        }
        public void setCurrentTool(State currentState)
        {
            this.currentState = currentState;
        }
    }
}
