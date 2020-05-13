using System;

namespace Gameframe.Giphy
{
  public enum GiphyRating
  {
    G,
    PG,
    PG13,
    R
  }

  public static class GiphyRatingExtensions
  {
    public static string ToQueryString(this GiphyRating rating)
    {
      switch (rating)
      {
        case GiphyRating.G:
          return "G";
        case GiphyRating.PG:
          return "PG";
        case GiphyRating.PG13:
          return "PG-13";
        case GiphyRating.R:
          return "R";
        default:
          throw new ArgumentOutOfRangeException(nameof(rating), rating, null);
      }
    }
  }
}