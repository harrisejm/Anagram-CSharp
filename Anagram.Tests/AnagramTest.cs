using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Anagram;
namespace Anagram.Tests
{

  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void GetAnagrams()
    {

      testWord word = new testWord();


      Assert.AreEqual("acr", word.test("car"));
    }


}

}
