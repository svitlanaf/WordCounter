using System;
using System.Linq;

namespace WordCounter
{
  public class Words
  {
    private string WordInput;
    private string SentenceInput;

    public Words (string wordInput, string sentenceInput)
    {
      WordInput = wordInput;
      SentenceInput = sentenceInput;
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

     public int CountWordMatchInSentence()
      {
        int count = 0;
        string userWord = WordInput.ToLower();
        string userSentence = SentenceInput.ToLower();
        string [] splitWords = userSentence.Split(' ');
        foreach (string eachWord in splitWords)
      {
        if (userWord == eachWord)
        {
          count ++;
        }
       }
          return count;
        }
    }
}
