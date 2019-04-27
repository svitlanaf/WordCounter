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
        {
          return false;
        }
      }
      return true;
    }

     public bool WordMatchInSentence(string WordInput, string SentenceInput)
      {
        string word = WordInput.ToLower();
        string sentence = SentenceInput.ToLower();
        string [] splitWords = sentence.Split(' ');
        foreach (string w in splitWords)
      {
        if (w == sentence)
        {
          return true;
        }
       }
          return false;
        }


    }
}
