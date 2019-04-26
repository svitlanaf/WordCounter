using System;
using System.Linq;

namespace Word
{
  public class Word
  {
    private string WordInput;

  public Word (string word)
    {
      WordInput = word;
    }

    public bool CheckWordIsString()
    {
      foreach (char word in WordInput)
      {
        if (!Char.IsLetter(word))
          return false;
        }
        return true;
      }

  }
}
