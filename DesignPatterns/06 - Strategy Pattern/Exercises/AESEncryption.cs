using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06___Strategy_Pattern.Exercises
{
    public class AESEncryption : Encryption
    {
        public string encrypt(string message)
        {
            Console.WriteLine("Encrypting message using AES");
            return "encryptedText";
        }
    }
}
