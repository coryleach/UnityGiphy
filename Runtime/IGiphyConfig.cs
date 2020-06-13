using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameframe.Giphy
{
  public interface IGiphyConfig
  {
    string ApiKey { get; }
    GiphyRating Rating { get; }
    string Lang { get; }
  }
}
