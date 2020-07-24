using System;
using Xunit;

namespace TesteXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(10, 20);
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(30, 30);
        }
    }
}
