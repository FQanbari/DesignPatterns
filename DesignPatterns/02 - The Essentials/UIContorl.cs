using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02___The_Essentials
{
    public abstract class UIContorl
    {
        public void enable()
        {
            Console.WriteLine("Enabled");
        }
        public abstract void draw();
    }
}
