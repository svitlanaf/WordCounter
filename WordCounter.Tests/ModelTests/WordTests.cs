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
      Words newWord = new Words("hello", "");
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
    public void CheckWordsAreMatching_UserInputsWordAndSentence_ReturnTrue()
    {
      string word = "sun";
      Words testWords = new Words(word, "");
      string sentence = "sun is shining";
      Words testWords = new Words("", sentence);
      word.SequenceEqual(sentence);
      
      // Words testWords = new Words("sun", "sun is shining");
      // testWords.WordsMatch("sun", "sun is shining");
      // Assert.AreEqual(true, testWords.WordsMatch());
    }
  }
}
