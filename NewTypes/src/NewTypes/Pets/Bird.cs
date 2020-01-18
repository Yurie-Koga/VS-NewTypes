using System;
namespace NewTypes.src.NewTypes.Pets
{
    public class Bird : IPet
    {
        public string TalkToOwner() => "Tweet!";
    }
}
