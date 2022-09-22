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
      char[] inputArray = InputWord.toStringArray().ToUpper();
      int score = 0;
      string[] one = new string[10] {"A", "E", "I", "O", "U", "L", "N", "R", "S", "T"};
      string[] two = new string[2] {"D", "G"};
      string[] three = new string[4] {"B", "C", "M", "P"};
      string[] four = new string[5] {"F", "H", "V", "W", "Y"};
      string[] five = new string[1] {"K"};
      string[] six = new string[2] {"J", "X"};
      for (int i=0; i<inputArray.Length; i++){
        if(one.Contains(inputArray[i])){
          score += 1;
        } else if (two.Contains(inputArray[i])){
          score += 2;
        } else if (three.Contains(inputArray[i])){
          score += 3;
        } else if (four.Contains(inputArray[i])){
          score += 4;
        } else if (five.Contains(inputArray[i])){
          score += 5;
        } else if (six.Contains(inputArray[i])){
          score += 8;
        } else {  //For Q & Z
          score += 10;
        }
      }
      return score;
    }
  }
}
