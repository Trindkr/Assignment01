using Xunit;
using static Assignment1.RegExpr;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void TestName()
        {
        //Given
            var input = new string[]{"cover 4274 image,& and related `??","trade%/&% dress 2323 are trademarks"};
        //When
            var output = SplitLine(input);
        //Then
            Assert.Equal(new string[]{"cover","4274", "image","and","related","trade,","dress","2323","are","trademarks"},output);
        }
    }
}
