using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {   

            //Arrange Test Data
            var x = 5;
            var y = 2;
            var expected = 7;

            //Act - computes some result
            var actual = x *y;

            //Assert - checks the values
            Assert.Equal(expected, actual);

        }
    }
}
