using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._04___State_Pattern.abuse
{
    public class StoppedState : State
    {
        private Stopwatch stopwatch;
        public StoppedState(Stopwatch stopwatch)
        {
            this.stopwatch = stopwatch;
        }
        public void click()
        {
            stopwatch.setCurrentTool(new RunningState(stopwatch));
            Console.WriteLine("Running");
        }
    }
}
