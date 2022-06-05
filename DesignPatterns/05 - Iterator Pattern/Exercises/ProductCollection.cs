using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._05___Iterator_Pattern.Exercises
{
    public class ProductCollection<T>
    {
        private List<T> products = new List<T>();

        public void add(T product)
        {
            products.Add(product);
        }
        public Iterator<T> createIterator()
        {
            return new ListIterator(this);
        }
        public class ListIterator : Iterator<T>
        {
            private ProductCollection<T> collection;
            private int index;

            public ListIterator(ProductCollection<T> history)
            {
                this.collection = history;
            }
            public T current()
            {
                return collection.products[index];
            }
            public bool hasNext()
            {
                return (index < collection.products.Count());
            }
            public void next()
            {
                index++;
            }
        }
    }
}
