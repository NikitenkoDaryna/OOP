using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB6
{
    class Collection<T>
    {
        private T[] arr = new T[100];
        int nextIndex = 0;
        // Define the indexer to allow client code to use [] notation.
        
        public T this[int i] => arr[i];
        

        public void Add(T value)
        {
            if (nextIndex >= arr.Length)
                throw new IndexOutOfRangeException($"The collection can hold only {arr.Length} elements.");
            arr[nextIndex++] = value;
        }
    }
}
