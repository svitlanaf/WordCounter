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
      Words newWord = new Words("hello", "hello there");
      Assert.AreEqual(typeof(Words), newWord.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      string WordInput = "sun";
      Words newWord = new Words (WordInput, "");
      string result = newWord.GetWord();
      Assert.AreEqual(WordInput, result);
    }

    [TestMethod]
    public void GetSentence_ReturnsSentence_String()
    {
      string SentenceInput = "sun is shining";
      Words newWord = new Words ("", SentenceInput);
      string result = newWord.GetSentence();
      Assert.AreEqual(SentenceInput, result);
    }

    [TestMethod]
    public void CheckWordIsString_UserInputsWord_ReturnTrue()
    {
      Words testWord = new Words("dog", "");
      Assert.AreEqual(true, testWord.CheckWordIsString());
    }

    [TestMethod]
    public void CheckWordIsString_UserInputsNonWord_ReturnFalse()
    {
      Words testWord = new Words("45", "");
      Assert.AreEqual(false, testWord.CheckWordIsString());
    }

    [TestMethod]
    public void CheckWordsAreMatching_UserInputsWordAndSentenceOfOneWord_ReturnTrue()
    {
      Words testWords = new Words("sun", "un");
      Assert.AreEqual(true, testWords.WordsMatch("sun", "sun"));
    }

    [TestMethod]
    public void CheckWordsAreNotMatching_UserInputsWordAndSentenceOfOneWord_ReturnTrue()
    {
      Words testWords = new Words("sun", "cat");
      Assert.AreEqual(false, testWords.WordsMatch("sun", "cat"));
    }

    [TestMethod]
    public void CheckWordsAreNotCaseSensitive1_UserInputsWordAndSentenceOfOneWord_ReturnTrue()
    {
      Words testWords = new Words("sun", "sUn");
      Assert.AreEqual(true, testWords.WordsMatch("sun", "sUn"));
    }

    [TestMethod]
    public void CheckWordsAreNotCaseSensitive2_UserInputsWordAndSentenceOfOneWord_ReturnTrue()
    {
      Words testWords = new Words("fan", "FAN");
      Assert.AreEqual(true, testWords.WordsMatch("fan", "FAN"));
    }
  }
}
