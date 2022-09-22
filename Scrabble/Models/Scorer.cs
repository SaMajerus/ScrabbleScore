using System;
//using System.linq;
/*     Business Logic     */ 
namespace WordFilter.Models
{
  public class Scrabble
  {
    public string InputWord { get; set; }
    
    public Scrabble (string inputWord)
    {
      InputWord = inputWord;
    }

    public int GetScore()
    {
      string inputArray = InputWord.ToUpper();  //At this website, see the section "Access Strings": https://www.w3schools.com/cs/cs_strings.php
      //Console.WriteLine(inputArray); //Confirm that 'inputArray' is formatted correctly.
      int score = 0;
      // string[] one = new string[10] {"A", "E", "I", "O", "U", "L", "N", "R", "S", "T"};
      // string[] two = new string[2] {"D", "G"};
      // string[] three = new string[4] {"B", "C", "M", "P"};
      // string[] four = new string[5] {"F", "H", "V", "W", "Y"};
      // string[] five = new string[1] {"K"};
      // string[] six = new string[2] {"J", "X"};
      
      for (int i=0; i<inputArray.Length; i++)
      {
        if ((inputArray[i] == 'A') || (inputArray[i] == 'E') || (inputArray[i] == 'I') || (inputArray[i] == 'O') || (inputArray[i] == 'U') || (inputArray[i] == 'L') || (inputArray[i] == 'N') || (inputArray[i] == 'R') || (inputArray[i] == 'S') || (inputArray[i] == 'T'))
        {
          score += 1;
        } 
        else if ((inputArray[i] == 'D') || (inputArray[i] == 'G'))
        {
          score += 2;
        } 
        else if ((inputArray[i] == 'B') || (inputArray[i] == 'C') || (inputArray[i] == 'M') || (inputArray[i] == 'P'))
        {
          score += 3;
        } 
        else if ((inputArray[i] == 'F') || (inputArray[i] == 'H') || (inputArray[i] == 'V') || (inputArray[i] == 'W') || (inputArray[i] == 'Y'))
        {
          score += 4;
        } 
        else if (inputArray[i] == 'K')
        {
          score += 5;
        } 
        else if (inputArray[i] == 'J' || inputArray[i] == 'X')
        {
          score += 8;
        } 
        else 
        {  //For Q & Z
          score += 10;
        }
      }
      return score;
    }
  }
}
