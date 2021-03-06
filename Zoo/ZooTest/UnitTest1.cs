using System;
using Xunit;
using Zoo.Class;

namespace ZooTest
{
    public class UnitTest1
    {
        [Fact]
        public void OwlIsABird()
        {
            Owl owl = new Owl();
            Assert.True(owl is Bird);
        }

        [Fact]
        public void OwlCanFly()
        {
            Owl owl = new Owl();
            Assert.True(owl.CanFly());
        }

        [Fact]
        public void GuppyIsAnimal()
        {
            Guppy guppy = new Guppy();
            Assert.True(guppy is Animal);
        }

        [Fact]
        public void GuppiesEatFood()
        {
            Guppy guppy = new Guppy();
            Equals(guppy.EatsFood());
        }

        [Fact]
        public void ChinnokSwim()
        {
           Chinook chinook = new Chinook();
            Assert.True(chinook.Swims());
        }

        [Fact]
        public void ChinnokIsAFish()
        {
            Chinook chinook = new Chinook();
            Assert.True(chinook is Fish);
        }

        [Fact]
        public void SockeyeIsFish()
        {
            Sockeye sockeye = new Sockeye();
            Assert.True(sockeye is Fish);
        }

        [Fact]
        public void SockeyeCanSwim()
        {
            Sockeye sockeye = new Sockeye();
            Assert.True(sockeye.Swims());
        
        }

        [Fact]
        public void AfricanPenguinIsBird()
        {
            AfricanPenguin africanPenguin = new AfricanPenguin();
            Assert.True(africanPenguin is Bird);
        }

        [Fact]
        public void AfricanPenguinHasWings()
        {
            AfricanPenguin africanPenguin = new AfricanPenguin();
            Assert.True(africanPenguin.CanFly());
        }
    }
}
