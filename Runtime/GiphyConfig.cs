using UnityEngine;

namespace Gameframe.Giphy
{
  [CreateAssetMenu(menuName = "Gameframe/Giphy/Config")]
  public class GiphyConfig : ScriptableObject
  {
    [SerializeField]
    private string apiKey = "";
    public string ApiKey => apiKey;
    
    [SerializeField]
    private GiphyRating rating = GiphyRating.PG13;
    public GiphyRating Rating => rating;
    
    [SerializeField]
    private string lang = "en";
    public string Lang => lang;
  }
}


