using System;
namespace NewTypes.src.NewTypes.Pets
{
    public class Dog : IPet
    {
        public string TalkToOwner() => "Woof!";
    }
}
