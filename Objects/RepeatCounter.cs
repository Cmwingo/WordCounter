using System;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    private string _searchWord;
    private string _searchString;
    private int _wordCount = 0;

    public RepeatCounter(string searchWord, string searchString)
    {
      _searchWord = searchWord;
      _searchString = searchString;
    }

    public int CountRepeats()
    {
      return 0;
    }
  }
}
