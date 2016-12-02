using System;
using Xunit;
using WordCounter.Objects;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounterTest1_Identical_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("A", "A");
      Assert.Equal(1, testRepeatCounter.CountRepeats());
    }

    [Fact]
    public void RepeatCounterTest1_Identical_False()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("A", "I");
      Assert.Equal(0, testRepeatCounter.CountRepeats());
    }
  }
}
