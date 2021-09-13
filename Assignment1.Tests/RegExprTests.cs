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


        
    [Fact]
    public void TestName()
    {
    //Given
    string input = @"<div>  <p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=""/wiki/Theoretical_computer_science"" title=""Theoretical computer science"">theoretical computer science</a> and <a href=""/wiki/Formallanguage"" title=""Formal language"">formal language</a> theory, a sequence of <a href=""/wiki/Character(computing)"" title=""Character (computing)"">characters</a> that define a <i>search <a href=""/wiki/Pattern_matching"" title=""Pattern matching"">pattern</a></i>. Usually this pattern is then used by <a href=""/wiki/String_searchingalgorithm"" title=""String searching algorithm"">string searching algorithms</a> for ""find"" or ""find and replace"" operations on <a href=""/wiki/String(computer_science)"" title=""String (computer science)"">strings</a>.</p> </div>";
   
    string tag="a";
    
    //When
    var output = InnerText(input,tag);

    //Then
    Assert.Equal( new string[]{"theoretical computer science","formal language","characters","pattern","string searching algorithms","strings"},output);
    
    }
    }



    
    
}
