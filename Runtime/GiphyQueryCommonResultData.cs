using System;
using UnityEngine;

namespace Gameframe.Giphy
{
    [Serializable]
    public class GiphyQueryCommonResultData
    {
        [SerializeField] private string type;
        [SerializeField] private string id;
        [SerializeField] private string url;
        [SerializeField] private string slug;
        [SerializeField] private string bitly_gif_url;
        [SerializeField] private string bitly_url;
        [SerializeField] private string embed_url;
        [SerializeField] private string username;
        [SerializeField] private string source;
        [SerializeField] private string title;
        [SerializeField] private string rating;
        [SerializeField] private string content_url;
        [SerializeField] private string source_tld;
        [SerializeField] private int is_sticker;

        public int IsSticker => is_sticker;
        public string SourceTld => source_tld;
        public string ContentUrl => content_url;
        public string Rating => rating;
        public string Title => title;
        public string Source => source;
        public string Username => username;
        public string EmbedUrl => embed_url;
        public string BitlyUrl => bitly_url;
        public string BitlyGifUrl => bitly_gif_url;
        public string Slug => slug;
        public string Url => url;
        public string Id => id;
        public string Type1 => type;
    }
    
    [Serializable]
    public class GiphyQueryMetaData
    {
        [SerializeField] private int status;
        [SerializeField] private string msg;
        [SerializeField] private string response_id;

        public int Status => status;
        public string Msg => msg;
        public string ResponseId => response_id;
    }

    [Serializable]
    public class GiphyQueryPaginationData
    {
        [SerializeField] private int total_count;
        [SerializeField] private int count;
        [SerializeField] private int offset;

        public int TotalCount => total_count;
        public int Count => count;
        public int Offset => offset;
    }
}
