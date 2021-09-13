using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            
            foreach (string item in lines)
            {
                string[] temp = Regex.Split(item, @"\W+\s*");
                temp = temp.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                foreach  (string item2 in temp)
                {
                    yield return item2;
                }

                
                temp = null;
            }

        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            throw new NotImplementedException();
        }
    }
}
