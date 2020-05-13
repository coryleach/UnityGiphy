using System;
using System.Collections.Generic;

namespace Gameframe.Giphy
{
  [Serializable]
  public class GiphyQuerySearchResult
  {
    public List<GiphyQuerySearchResultData> data;
    public GiphyQueryPaginationData pagination;
    public GiphyQueryMetaData meta;
  }
    
  [Serializable]
  public class GiphyQuerySearchResultData : GiphyQueryCommonResultData
  {
    public GiphyGifResultImagesData images;
  }
    
  [Serializable]
  public class GiphyGifResultImagesData
  {
    public GiphyImageData original_mp4;
    public GiphyImageData downsized_large;
    public GiphyImageData fixed_height_small_still;
    public GiphyImageData original;
    public GiphyImageData fixed_height_downsampled;
    public GiphyImageData downsized_still;
    public GiphyImageData fixed_height_still;
    public GiphyImageData downsized_medium;
    public GiphyImageData downsized;
    public GiphyImageData preview_webp;
    public GiphyImageData fixed_height_small;
    public GiphyImageData fixed_height;
    public GiphyImageData downsized_small;
    public GiphyImageData preview;
    public GiphyImageData fixed_width_downsampled;
    public GiphyImageData fixed_width_small_still;
    public GiphyImageData fixed_width_small;
    public GiphyImageData original_still;
    public GiphyImageData fixed_width_still;
    public GiphyImageData looping;
    public GiphyImageData fixed_width;
    public GiphyImageData preview_gif;
  }

  [Serializable]
  public class GiphyImageData
  {
    public int height;
    public int width;
    public int size;
    public string hash;
    public string url;
    public string mp4;
    public int mp4_size;
    public string webp;
    public int webp_size;
  }
}