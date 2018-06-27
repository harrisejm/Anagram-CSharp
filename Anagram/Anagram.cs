using System;
using System.Collections.Generic;

namespace Anagram
{
  public class testWord
  {
  public string test(string testWord)
  {
  string sortedWord = "";
  List<string>anagramList = new List<string>{};

    char[] array = testWord.ToCharArray();
    Array.Sort(array);
    sortedWord = string.Join("", array);
    anagramList.Add(sortedWord);

    return anagramList[0];


  }
}
class AnagramApp
{
  static void Main()
  {
    testWord word = new testWord();
    Console.WriteLine("Please Enter Anagram");
    string anagram = Console.ReadLine();
    //word.test(anagram)
    Console.WriteLine(word.test(anagram));
   //Console.WriteLine("Your anagram is " + anagram);
    if (anagram == "stop")
    {
      Console.WriteLine("TEST");
    }
    else
    {
      Main();
    }
  }
}

}
