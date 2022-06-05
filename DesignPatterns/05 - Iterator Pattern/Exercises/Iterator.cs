using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._05___Iterator_Pattern.Exercises
{
    public interface Iterator<T>
    {
        bool hasNext();
        T current();
        void next();
    }
}
