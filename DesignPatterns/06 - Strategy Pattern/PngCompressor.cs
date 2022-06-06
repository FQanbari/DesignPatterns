using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06___Strategy_Pattern
{
    public class PngCompressor : Compressor
    {
        public void compress(string fileName)
        {
            Console.WriteLine("Compressing using PNG");
        }
    }
}
