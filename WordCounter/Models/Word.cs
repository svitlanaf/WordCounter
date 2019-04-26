using System;
using System.Linq;

namespace Word
{
  public class Word
  {
    public string WordInput;
    public string SentenceInput;

  public Word (string word)
    {
      this.WordInput = word;
      // this.SentenceInput = sentence;
    }

    public static bool CheckWord(string word)
    {
      foreach (char w in word)
      {
        if (!Char.IsLetter(w))
          return false;
        }
        return false;
      }

  }
}
