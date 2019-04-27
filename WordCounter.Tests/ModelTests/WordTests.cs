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
      string wordInput = "sun";
      Words newWord = new Words (wordInput, "");
      string result = newWord.GetWord();
      Assert.AreEqual(wordInput, result);
    }

    [TestMethod]
    public void GetSentence_ReturnsSentence_String()
    {
      string sentenceInput = "sun is shining";
      Words newWord = new Words ("", sentenceInput);
      string result = newWord.GetSentence();
      Assert.AreEqual(sentenceInput, result);
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
      Words testWords = new Words("", "");
      Assert.AreEqual(true, testWords.WordMatchInSentence("sun", "sun"));
    }

    [TestMethod]
    public void CheckWordsAreNotMatching_UserInputsWordAndSentenceOfOneWord_ReturnTrue()
    {
      Words testWords = new Words("sun", "cat");
      Assert.AreEqual(false, testWords.WordMatchInSentence("sun", "cat"));
    }

    [TestMethod]
    public void CheckWordsAreNotCaseSensitive1_UserInputsWordAndSentenceOfOneWord_ReturnTrue()
    {
      Words testWords = new Words("sun", "sUn");
      Assert.AreEqual(true, testWords.WordMatchInSentence("sun", "sUn"));
    }

    [TestMethod]
    public void CheckWordsAreNotCaseSensitive2_UserInputsWordAndSentenceOfOneWord_ReturnTrue()
    {
      Words testWords = new Words("fan", "FAN");
      Assert.AreEqual(true, testWords.WordMatchInSentence("fan", "FAN"));
    }

    [TestMethod]
    public void CheckWordIsNone_UserInputWordIsNone_ReturnFalse()
    {
      Words testWords = new Words(" ", "dog");
      Assert.AreEqual(false, testWords.WordMatchInSentence(" ", "dog"));
    }

    [TestMethod]
    public void CheckSentenceIsNone_UserInputSentenceIsNone_ReturnFalse()
    {
      Words testWords = new Words("cat", " ");
      Assert.AreEqual(false, testWords.WordMatchInSentence("cat", " "));
    }

    [TestMethod]
    public void CheckSentenceAndWordAreNone_UserInputSentenceIsNoneAndUserInputWordIsNone_ReturnFalse()
    {
      Words testWords = new Words(" ", " ");
      Assert.AreEqual(false, testWords.WordMatchInSentence(" ", " "));
    }

    [TestMethod]
    public void CheckWordsAreMatching_UserInputsWordAndSentence_ReturnTrue()
    {
      Words testWords = new Words("sun", "sun, fun, run");
      Assert.AreEqual(true, testWords. WordMatchInSentence("sun", "sun"));
    }

    [TestMethod]
    public void CheckWordsAreNotMatching_UserInputsWordAndSentence_ReturnFalse()
    {
      Words testWords = new Words("sun", "gun, fun, run");
      Assert.AreEqual(false, testWords.WordMatchInSentence("sun", " "));
    }
  }
}
