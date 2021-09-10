using System;
using System.Collections.Generic;


namespace Assignment1
{
    public static class Iterators
    {
        
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

            throw new NotImplementedException(); 
            /*foreach (var item in items)
            {
                if(predicate)
                {   
                    yield return item;
                }
            }
            */
            //TODO
        }

        public static bool even(int input)
        {
            return input % 2 == 0;
        }
    }
}
