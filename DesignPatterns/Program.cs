using DesignPatterns._02___The_Essentials;
using DesignPatterns._03___Memento_Pattern;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new Document();
            var history = new DocumentHistory();

            document.setContent("Hello");
            history.push(document.createState());

            document.setFontName("Font 1");
            history.push(document.createState());

            document.setFontSize(10);

            Console.WriteLine(document.toString());

            document.restore(history.pop());
            Console.WriteLine(document.toString());

            document.restore(history.pop());
            Console.WriteLine(document.toString());
        }        
    }
}
