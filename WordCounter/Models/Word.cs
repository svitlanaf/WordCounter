using System;
using System.Linq;

namespace WordCounter
{
  public class Word
  {
    private string WordInput;
    private string SentenceInput;

  public Word (string word)
    {
      WordInput = word;
    }

    public string GetWord()
    {
      return WordInput;
    }

    public bool CheckWordIsString()
    {
      foreach (char userWord in WordInput)
      {
        if (!Char.IsLetter(userWord))
          return false;
        }
        return true;
      }

      // public static bool MatchingWords(string word1, string word2)
      // {
      //   char[] charArray1 = word1.ToLower().ToCharArray();
      //   Array.Sort(charArray1);
      //
      //   char[] charArray2 = word2.ToLower().ToCharArray();
      //   Array.Sort(charArray2);
      //
      //   return charArray1.SequenceEqual(charArray2);
      // }
  }
}
