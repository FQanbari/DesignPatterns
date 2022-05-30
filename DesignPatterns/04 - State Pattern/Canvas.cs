using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._04___State_Pattern
{
    public class Canvas
    {
        private Tool currentTool;
        public void mouseDown()
        {
            currentTool.mouseDown();
        }
        public void mouseUp()
        {
            currentTool.mouseUp(); 
        }
        public Tool getCurrentTool()
        {
            return currentTool;
        }
        public void setCurrentTool(Tool currentTool)
        {
            this.currentTool = currentTool;
        }
    }
}
