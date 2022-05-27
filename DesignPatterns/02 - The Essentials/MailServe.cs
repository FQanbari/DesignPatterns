using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02___The_Essentials
{
    public class MailServe
    {
        public void sendEmail()
        {
            connect(3);
            authenticate();
            disconnect();
        }
        private void connect(int timeout)
        {
            Console.WriteLine("connect");
        }
        private void disconnect()
        {
            Console.WriteLine("Disconnect");
        }
        private void authenticate()
        {
            Console.WriteLine("Authenticate");
        }
    }
}
