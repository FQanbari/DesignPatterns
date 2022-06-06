using DesignPatterns._02___The_Essentials;
using DesignPatterns._03___Memento_Pattern;
using DesignPatterns._04___State_Pattern;
using DesignPatterns._04___State_Pattern.abuse;
using DesignPatterns._04___State_Pattern.Exercises;
using DesignPatterns._05___Iterator_Pattern;
using DesignPatterns._06___Strategy_Pattern;
using DesignPatterns._06___Strategy_Pattern.Exercises;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageStore = new ImageStorage();
            imageStore.store("a", new PngCompressor(), new BlackAndWhiteFilter());

            var chat = new ChatClient();
            chat.send("message", new AESEncryption());
        }     
    }
}
