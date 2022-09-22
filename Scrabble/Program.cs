using System;
using System.Collections.Generic;
using WordFilter.Models;

/*     UI Logic     */ 
namespace WordFilter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Scrabble Point Tracker");
      Console.WriteLine("Enter any word: ");
      string inputWord = Console.ReadLine().ToLower();
      Scrabble word = new Scrabble(inputWord);
      Console.WriteLine("Your word is worth: " + word.GetScore() + " Points");
      Console.WriteLine("");
    } 
  }
}