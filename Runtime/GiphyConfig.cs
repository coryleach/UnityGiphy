using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameframe.Giphy
{
  [CreateAssetMenu(menuName = "Gameframe/Giphy/Config")]
  public class GiphyConfig : ScriptableObject
  {
    public string apiKey = "";
    public GiphyRating rating = GiphyRating.PG13;
    public string lang = "en";
  }
}


