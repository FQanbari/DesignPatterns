using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02___The_Essentials
{
    class User
    {
        // Fields (attributes)
        private string name;

        public User(string name, int age)
        {
            this.name = name;
        }
        // Methods
        public void sayHello()
        {
            Console.WriteLine("- Hi, my name is " + this.name);
        }
    }
}
