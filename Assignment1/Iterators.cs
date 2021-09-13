using System;
using System.Collections.Generic;


namespace Assignment1
{
    
    public static class Iterators
    {
      
        public static bool Even(int input)
        {
                return input % 2 == 0;
        }
        
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
        {
            foreach (var i in items)
            {
                foreach (var j in i)
                {
                    yield return j;
                }
            }
        }

        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
        {

            foreach (var i in items)
            {
                if(predicate(i))
                {   
                    yield return i;
                }
            }
        }   
    }
}
