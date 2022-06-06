using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._06___Strategy_Pattern
{
    public class BlackAndWhiteFilter : Filter
    {
        public void apply(string fileName)
        {
            Console.WriteLine("Applying B&W filter");
        }
    }
}
