using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._04___State_Pattern
{
    class EraserTool : Tool
    {
        public void mouseDown()
        {
            Console.WriteLine("Eraser icon");
        }
        public void mouseUp()
        {
            Console.WriteLine("Erase something");
        }
    }
}
