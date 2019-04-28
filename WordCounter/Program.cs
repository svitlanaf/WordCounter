using System;
using System.Linq;
using System.Collections.Generic;


namespace WordCounter
{
    public class Program
    {
      public static void Main()
      {
        Console.WriteLine("Enter a word");
        string userWord = Console.ReadLine();
        Console.WriteLine("Enter a sentence");
        string userSentence = Console.ReadLine();

        Words testWords = new Words(userWord, userSentence);
        Console.WriteLine("Your word '" + userWord + "' appears " + testWords.CountWordMatchInSentence() + "  times in the sentence.");
        }
      }
  }
