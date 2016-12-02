using Nancy;
using WordCounter.Objects;
using System;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Post["/count"] = _ =>
      {
        RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["search-word"], Request.Form["search-string"]);
        newRepeatCounter.CountRepeats();
        return View["word_count.cshtml", newRepeatCounter];
      };
    }
  }
}
