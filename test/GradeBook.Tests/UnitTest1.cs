using System;
using Xunit;

namespace GradeBook.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var x = 5;
            var y = 2;

            var expected = x+y;
            
            Assert.Equal(9, expected);
        }
    }
}