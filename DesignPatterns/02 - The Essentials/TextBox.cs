using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02___The_Essentials
{
    public class TextBox : UIContorl
    {
        public override void draw()
        {
            Console.WriteLine("Drawing a textbox");
        }
    }
}
