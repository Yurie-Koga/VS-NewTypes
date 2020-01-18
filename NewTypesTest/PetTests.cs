using System;
using Xunit;
using Pets;

namespace NewTypesTest
{
    public class PetTests
    {
        [Fact]
        public void DogTalkToOwnerReturnsWoof()
        {
            string expected = "Woof!";
            string actual = new Dog().TalkToOwner();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CatTalkToOwnerReturnsWoof()
        {
            string expected = "Meow!";
            string actual = new Cat().TalkToOwner();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BirdTalkToOwnerReturnsWoof()
        {
            string expected = "Tweet!";
            string actual = new Bird().TalkToOwner();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LionTalkToOwnerReturnsWoof()
        {
            string expected = "Roar!";
            string actual = new Lion().TalkToOwner();

            Assert.Equal(expected, actual);
        }
    }
}
