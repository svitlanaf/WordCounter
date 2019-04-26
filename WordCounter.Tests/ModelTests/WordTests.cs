using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("hello");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      string WordInput = "sun";
      Word newWord = new Word (WordInput);
      string result = newWord.GetWord();
      Assert.AreEqual(WordInput, result);
    }

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

    // [TestMethod]
    // public void CheckWordsAreMatching_UserInputsWordAndSentence_ReturnTrue()
    // {
    //
    // }
  }
}
