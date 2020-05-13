using System;

namespace Gameframe.Giphy
{
    [Serializable]
    public class GiphyQueryCommonResultData
    {
        public string type;
        public string id;
        public string url;
        public string slug;
        public string bitly_gif_url;
        public string bitly_url;
        public string embed_url;
        public string username;
        public string source;
        public string title;
        public string rating;
        public string content_url;
        public string source_tld;
        public int is_sticker;
    }
    
    [Serializable]
    public class GiphyQueryMetaData
    {
        public int status;
        public string msg;
        public string response_id;
    }

    [Serializable]
    public class GiphyQueryPaginationData
    {
        public int total_count;
        public int count;
        public int offset;
    }
}
