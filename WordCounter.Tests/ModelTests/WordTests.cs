using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word;

namespace Word.Tests
{
  [TestClass]
  public class WordTest
  {

    [TestMethod]
    public void CheckWordIsString_UserInputsWord_ReturnTrue()
    {
      Word testWord = new Word("dog");
      Assert.AreEqual(true, testWord.CheckWordIsString());
    }

    [TestMethod]
    public void CheckWordIsString_UserInputsNonWord_ReturnFalse()
    {
      Word testWord = new Word("45");
      Assert.AreEqual(false, testWord.CheckWordIsString());
    }
  }
}
