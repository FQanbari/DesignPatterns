using DesignPatterns._02___The_Essentials;
using DesignPatterns._03___Memento_Pattern;
using DesignPatterns._04___State_Pattern;
using DesignPatterns._04___State_Pattern.abuse;
using DesignPatterns._04___State_Pattern.Exercises;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var directionService = new DirectionService(new Walking());
            directionService.getDirection();
            directionService.getEta();
        }     
    }
}
