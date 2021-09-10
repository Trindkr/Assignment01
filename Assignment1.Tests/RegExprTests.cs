using Xunit;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
<<<<<<< Updated upstream
=======
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
>>>>>>> Stashed changes
    }
}
