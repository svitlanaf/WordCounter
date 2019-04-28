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
      Words testWord = new Words("", "");
      Assert.AreEqual(false, testWord.CheckWordIsString());
    }

    [TestMethod]
    public void CheckWordsAreMatching_UserInputsWordAndSentenceOfOneWord_ReturnCount1()
    {
      Words testWords = new Words("sun", "sun");
      Assert.AreEqual(1, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckWordsAreNotMatching_UserInputsWordAndSentenceOfOneWord_ReturnCount0()
    {
      Words testWords = new Words("sun", "cat");
      Assert.AreEqual(0, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckWordsAreNotCaseSensitive1_UserInputsWordAndSentenceOfOneWord_ReturnCount1()
    {
      Words testWords = new Words("sun", "sUn");
      Assert.AreEqual(1, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckWordsAreNotCaseSensitive2_UserInputsWordAndSentenceOfOneWord_ReturnCount1()
    {
      Words testWords = new Words("fan", "FAN");
      Assert.AreEqual(1, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckWordIsNone_UserInputWordIsNone_ReturnCount0()
    {
      Words testWords = new Words("", "dog");
      Assert.AreEqual(0, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckSentenceIsNone_UserInputSentenceIsNone_ReturnCount0()
    {
      Words testWords = new Words("cat", "");
      Assert.AreEqual(0, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckSentenceAndWordAreNone_UserInputSentenceIsNoneAndUserInputWordIsNone_ReturnCount0()
    {
      Words testWords = new Words("", "");
      Assert.AreEqual(0, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckWordsAreMatching_UserInputsWordAndSentence_ReturnCount1()
    {
      Words testWords = new Words("sun", "sun fun run");
      Assert.AreEqual(1, testWords. CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckWordsAreNotMatching_UserInputsWordAndSentence_ReturnCount0()
    {
      Words testWords = new Words("sun", "gun fun run");
      Assert.AreEqual(0, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckWordsInSentenceAreNotCaseSensitive_UserInputsWordAndSentence_ReturnCount3()
    {
      Words testWords = new Words("fan", "FAN Fan faN man");
      Assert.AreEqual(3, testWords.CountWordMatchInSentence());
    }

    [TestMethod]
    public void CheckFullWordsAreMatching_UserInputsWordAndSentenceThatHaveWordsStartsWithSameLettersAsWord_ReturnCount1()
    {
      Words testWords = new Words("cat", "Cat has a hat at the cathedral");
      Assert.AreEqual(1, testWords.CountWordMatchInSentence());
    }

    }
  }
