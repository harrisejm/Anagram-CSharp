using System;
using System.Collections.Generic;

namespace Anagram
{
  public class testWord
  {
  public string testOutput;
  public string test(string testWord1)
  {
  string testWord = testWord1.ToLower();
  string sortedWord = "";

  List<string>anagramList = new List<string>{};

    char[] array = testWord.ToCharArray();
    Array.Sort(array);
    sortedWord = string.Join("", array);
    anagramList.Add(sortedWord);

    foreach(string wordItem in anagramList)
    {
    //  if (testWord == anagramList[wordItem]
      testOutput += wordItem + " ";
    }
    return testOutput;
  }
}

class AnagramApp
{
  static void Main()
  {
    testWord word = new testWord();
  string anagram = "";
  string testLine = "";
  string testLine1 = "";

      do {
    Console.WriteLine("Please Enter Anagram");
    anagram = Console.ReadLine();

    testLine = word.test(anagram);

    Console.WriteLine(testLine);
 } while (anagram != "stop");




    //  Main();
    }
  }
}
