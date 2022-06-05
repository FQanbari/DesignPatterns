using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._05___Iterator_Pattern
{
    public class ProductCollection<T>
    {
        private List<T> urls = new List<T>();
        //private T[] urls = new T[10];
        public void push(T url)
        {
            urls.Add(url);
        }
        public T pop(T url)
        {
            return urls[urls.Count - 1];
        }

        public Iterator<T> createIterator()
        {
            return new ListIterator(this);
        }
        public class ListIterator : Iterator<T>
        {
            private ProductCollection<T> history;
            private int index;

            public ListIterator(ProductCollection<T> history)
            {
                this.history = history;
            }
            public T current()
            {
                return history.urls[index];
            }
            public bool hasNext()
            {
                return (index < history.urls.Count());
            }
            public void next()
            {
                index++;
            }
        }
    }
}
