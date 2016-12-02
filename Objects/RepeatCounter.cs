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

    public string GetSearchWord()
    {
      return _searchWord;
    }

    public string GetSearchString()
    {
      return _searchString;
    }

    public int GetWordCount()
    {
      return _wordCount;
    }
    public int CountRepeats()
    {
      string[] searchStringWords = _searchString.Split(' ');
      foreach(string word in searchStringWords)
      {
        if(_searchWord.ToLower() == word.ToLower())
        {
          _wordCount += 1;
        }
      }
      return _wordCount;
    }
  }
}
