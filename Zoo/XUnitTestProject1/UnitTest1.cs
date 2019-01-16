using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void SalmonCanBeInstantiated()
        {
            Salmon salmon = new Salmon();
            Assert.Equal("salmon, salmon.Aniamal");
        }

        [Fact]
        public void SockeyeIsAnimal()
        {
            Sockeye sockeye = new Sockeye ();
            Assert.Equal("I am an animal", lives);
        }

        [Fact]
        public void ProveInterface()
            {
}
    }
}


