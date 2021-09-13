using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using static System.Collections.IEnumerable;

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

        public static IEnumerable<(int width, int height) > Resolution(IEnumerable<string>  resolutions)
        {
            foreach (string item in resolutions)
            {
                string[] temp = Regex.Split(item, @"[,]");

                foreach  (string item2 in temp)
                {
                    string[] temp2 = Regex.Split(item2, @"[x]");
                    
                    int width = Convert.ToInt32( temp2[0]);
                    int height = Convert.ToInt32( temp2[1]);

                    
                    yield return (width, height);
                
                }

                
                temp = null;
            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            throw new NotImplementedException();
        }
    }
}
