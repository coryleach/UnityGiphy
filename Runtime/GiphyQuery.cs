using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace Gameframe.Giphy
{
  public static class GiphyQuery
  {
    private const string searchApiUrl = "api.giphy.com/v1/gifs/search";
    private const string randomApiUrl = "api.giphy.com/v1/gifs/random";
    
    public static Task<GiphyQueryRandomResult> Random(GiphyConfig config, string tag)
    {
      var requestUrl = $"https://{randomApiUrl}?api_key={config.apiKey}&tag={UnityWebRequest.EscapeURL(tag)}&rating={config.rating.ToQueryString()}";
      return Query<GiphyQueryRandomResult>(requestUrl);
    }
    
    public static Task<GiphyQueryRandomResult> Random(string apiKey, string tag, GiphyRating rating = GiphyRating.PG13)
    {
      var requestUrl = $"https://{randomApiUrl}?api_key={apiKey}&tag={UnityWebRequest.EscapeURL(tag)}&rating={rating.ToQueryString()}";
      return Query<GiphyQueryRandomResult>(requestUrl);
    }

    public static Task<GiphyQuerySearchResult> Search(GiphyConfig config, string query, int limit = 25, int offset = 0)
    {
      var requestUrl = $"https://{searchApiUrl}?api_key={config.apiKey}&q={UnityWebRequest.EscapeURL(query)}&limit={limit}&offset={offset}&rating={config.rating.ToQueryString()}&lang={config.lang}";
      return Query<GiphyQuerySearchResult>(requestUrl);
    }
    
    public static Task<GiphyQuerySearchResult> Search(string apiKey, string query, int limit, int offset = 0, GiphyRating rating = GiphyRating.PG13, string lang = "en")
    {
      var requestUrl = $"https://{searchApiUrl}?api_key={apiKey}&q={UnityWebRequest.EscapeURL(query)}&limit={limit}&offset={offset}&rating={rating.ToQueryString()}&lang={lang}";
      return Query<GiphyQuerySearchResult>(requestUrl);
    }

    private static async Task<T> Query<T>(string requestUrl)
    {
      var request = UnityWebRequest.Get(requestUrl);

      await request.SendWebRequest();

      if (request.isNetworkError)
      {
        throw new NetworkErrorException(request.error);
      }
      
      if (request.isHttpError)
      {
        throw new HttpErrorException(request.error);
      }

      return JsonUtility.FromJson<T>(request.downloadHandler.text);
    }
    
  }

  public class NetworkErrorException : Exception {
    public NetworkErrorException(string msg) : base($"NetworkError:{msg}")
    {
    }
  }

  public class HttpErrorException : Exception
  {
    public HttpErrorException(string msg) : base($"HttpError:{msg}")
    {
    }
  }

}
