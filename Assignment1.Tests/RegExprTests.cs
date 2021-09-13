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
            var input = new string[]{"cover 4274 image,& and related `??"};
        //When "trade%/&% dress 2323 are trademarks"
            var output = SplitLine(input);
        //Then "trade","dress","2323","are","trademarks"
            Assert.Equal(new string[]{ "cover","4274", "image","and","related"},output);
        }
    }
}
