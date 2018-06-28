using System;
using System.Collections.Generic;

namespace Anagram
{
  public class testWord
  {
  public string _testOutput;
  public string _testAnagram;

  public testWord(string testOutput, string testAnagram)
  {
    _testOutput = testOutput;
    _testAnagram = testAnagram;
  }

  public string test(string _testOutput, string _testAnagram)
  {

  string testWord = _testOutput.ToLower();
  string testA = _testAnagram.ToLower();

  string sortedWord = "";
  string anagramWord = "";


    char[] array = testWord.ToCharArray();
    Array.Sort(array);
    sortedWord = string.Join("", array);


    char[] array1 = testA.ToCharArray();
    Array.Sort(array1);
    anagramWord = string.Join("", array1);

    string output = "";
    if (anagramWord == sortedWord)
      {
      output += _testOutput+ " IS AN anagram (to end game ENTER: stopNow)";
    }
    else
    {
      output += _testOutput+ " IS NOT an Anagram (to end game ENTER: stopNow)";
    }
    return output;
}
}

class AnagramApp
{
  static void Main()
  {
    Console.WriteLine("Please Enter word");
    string inputW = Console.ReadLine();
    string inputWord = "";
    string finalResult = "";
      do {
        Console.WriteLine("Please Enter Anagram of first word (to end game ENTER: stopNow");
        inputWord = Console.ReadLine();
      testWord word = new testWord(inputWord, inputW);
      finalResult = word.test(inputWord, inputW);
      Console.WriteLine(finalResult);
 } while (inputWord != "stopNow");


    }
  }
}
