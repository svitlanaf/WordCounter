using System;
using System.Linq;

namespace WordCounter
{
  public class Words
  {
    private string WordInput;
    private string SentenceInput;

  public Words (string word, string sentence)
    {
      WordInput = word;
      SentenceInput = sentence;
    }

    public string GetWord()
    {
      return WordInput;
    }

    public string GetSentence()
    {
      return SentenceInput;
    }

    public bool CheckWordIsString()
    {
      foreach (char character in WordInput)
      {
        if (!Char.IsLetter(character))
          return false;
        }
        return true;
      }

      public bool WordsMatch(string WordInput, string wordInSentence)
      {
        char[] charArray1 = WordInput.ToLower().ToCharArray();
        Array.Sort(charArray1);

        char[] charArray2 = wordInSentence.ToLower().ToCharArray();
        Array.Sort(charArray2);

        return charArray1.SequenceEqual(charArray2);

      }
    }
}
