using DesignPatterns._02___The_Essentials;
using DesignPatterns._03___Memento_Pattern;
using DesignPatterns._04___State_Pattern;
using DesignPatterns._04___State_Pattern.abuse;
using DesignPatterns._04___State_Pattern.Exercises;
using DesignPatterns._05___Iterator_Pattern;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                name = "Ahmad",
                family = "Mohammadi"
            };
            var history = new ProductCollection<Person>();
            history.push(person);
            history.push(new Person
            {
                name = "Maryam",
                family = "Rad"
            });
            history.push(new Person
            {
                name = "Zar",
                family = "Bani"
            });

            Iterator<Person> iterator = history.createIterator();
            while (iterator.hasNext())
            {
                var url = iterator.current();
                Console.WriteLine(url.name + " " + url.family);
                iterator.next();
            }
        }     
    }
    public class Person
    {
        public string name;
        public string family;
    }
}
