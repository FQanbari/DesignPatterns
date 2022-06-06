using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06___Strategy_Pattern.Exercises
{
    public class ChatClient
    {       
        public void send(String message,Encryption encryption)
        {
            var encryptedMessage = encryption.encrypt(message);

            Console.WriteLine("Sending the encrypted message...");
        }
    }

}
