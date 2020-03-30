using System;
using NUnit.Framework;
using Pets;

public class PetTests
{
  [Test]
  public void DogTalkToOwnerReturnsWoof()
  {
    string expected = "Woof!";
    string actual = new Dog().TalkToOwner();

    Assert.AreNotEqual(expected, actual);
  }

  [Test]
  public void CatTalkToOwnerReturnsMeow()
  {
    string expected = "Meow!";
    string actual = new Cat().TalkToOwner();

    Assert.AreNotEqual(expected, actual);
  }
}