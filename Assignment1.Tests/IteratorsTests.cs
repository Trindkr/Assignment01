using Xunit;
using System.Collections.Generic;
using System;
using static Assignment1.Iterators;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void Flatten_Given2DArray_returns1DArrayContainingAllItems()
        {
            //Given
            var subInput1 = new int[]{1,2,3,4,5,6};
            var subInput2 = new int[]{6,5,4,3,2,1};
            var input = new int[][]{subInput1,subInput2};
            
            //When
            var output = Flatten<int>(input);

            //Then
            Assert.Equal(new int[]{1,2,3,4,5,6,6,5,4,3,2,1},output);
        }

        [Fact]
        public void TestName()
        {
            //Given
            Predicate<int> predicate = Iterators.Even;
            var input = new int[]{3,4,5,6,2,8,6};
            
            //When
            var output = Filter<int>(input,predicate);
            
            //Then
            Assert.Equal(new int[]{4,6,2,8,6}, output);
        }
        
        
    }
}
