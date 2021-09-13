using Xunit;
using static Assignment1.RegExpr;
using System;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void Splitline_given_StringArray_return_only_numbers_and_Words()
        {
        //Given
            var input = new string[]{"cover 4274 image,& and related `??", "trade%/&% dress 2323 are trademarks"};
        //When 
            var output = SplitLine(input);
        //Then 
            Assert.Equal(new string[]{ "cover","4274", "image","and","related","trade","dress","2323","are","trademarks"},output);
        }

        [Fact]
        public void Resolution_given_stringArray_returning_tuples_of_int()
        {
        //Given
        var input = new string[]{"1920x1080", "1024x768, 800x600, 640x480", "320x200, 320x240, 800x600", "1280x960"};

        //When
        var output = Resolution(input);
        //Then
        var tupleList = new List<(int i,int j)>
        {
             (1920,1080),
             (1024,768),
             (800,600),
             (640, 480),
             (320, 200),
             (320, 240),
             (800, 600),
             (1280, 960)
        };

            Assert.Equal(tupleList, output);        
        }
    }

    
    
}
