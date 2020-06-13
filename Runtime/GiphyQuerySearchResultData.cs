using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gameframe.Giphy
{
  [Serializable]
  public class GiphyQuerySearchResult
  {
    [SerializeField] private List<GiphyQuerySearchResultData> data;
    [SerializeField] private GiphyQueryPaginationData pagination;
    [SerializeField] private GiphyQueryMetaData meta;

    public IReadOnlyList<GiphyQuerySearchResultData> Data => data;
    public GiphyQueryPaginationData Pagination => pagination;
    public GiphyQueryMetaData Meta => meta;
  }
    
  [Serializable]
  public class GiphyQuerySearchResultData : GiphyQueryCommonResultData
  {
    [SerializeField] private GiphyGifResultImagesData images;

    public GiphyGifResultImagesData Images => images;
  }
    
  [Serializable]
  public class GiphyGifResultImagesData
  {
    [SerializeField] private GiphyImageData original_mp4;
    [SerializeField] private GiphyImageData downsized_large;
    [SerializeField] private GiphyImageData fixed_height_small_still;
    [SerializeField] private GiphyImageData original;
    [SerializeField] private GiphyImageData fixed_height_downsampled;
    [SerializeField] private GiphyImageData downsized_still;
    [SerializeField] private GiphyImageData fixed_height_still;
    [SerializeField] private GiphyImageData downsized_medium;
    [SerializeField] private GiphyImageData downsized;
    [SerializeField] private GiphyImageData preview_webp;
    [SerializeField] private GiphyImageData fixed_height_small;
    [SerializeField] private GiphyImageData fixed_height;
    [SerializeField] private GiphyImageData downsized_small;
    [SerializeField] private GiphyImageData preview;
    [SerializeField] private GiphyImageData fixed_width_downsampled;
    [SerializeField] private GiphyImageData fixed_width_small_still;
    [SerializeField] private GiphyImageData fixed_width_small;
    [SerializeField] private GiphyImageData original_still;
    [SerializeField] private GiphyImageData fixed_width_still;
    [SerializeField] private GiphyImageData looping;
    [SerializeField] private GiphyImageData fixed_width;
    [SerializeField] private GiphyImageData preview_gif;

    public GiphyImageData OriginalMp4 => original_mp4;
    public GiphyImageData DownsizedLarge => downsized_large;
    public GiphyImageData FixedHeightSmallStill => fixed_height_small_still;
    public GiphyImageData Original => original;
    public GiphyImageData FixedHeightDownsampled => fixed_height_downsampled;
    public GiphyImageData DownsizedStill => downsized_still;
    public GiphyImageData FixedHeightStill => fixed_height_still;
    public GiphyImageData DownsizedMedium => downsized_medium;
    public GiphyImageData Downsized => downsized;
    public GiphyImageData PreviewWebp => preview_webp;
    public GiphyImageData FixedHeightSmall => fixed_height_small;
    public GiphyImageData FixedHeight => fixed_height;
    public GiphyImageData DownsizedSmall => downsized_small;
    public GiphyImageData Preview => preview;
    public GiphyImageData FixedWidthDownsampled => fixed_width_downsampled;
    public GiphyImageData FixedWidthSmallStill => fixed_width_small_still;
    public GiphyImageData FixedWidthSmall => fixed_width_small;
    public GiphyImageData OriginalStill => original_still;
    public GiphyImageData FixedWidthStill => fixed_width_still;
    public GiphyImageData Looping => looping;
    public GiphyImageData FixedWidth => fixed_width;
    public GiphyImageData PreviewGif => preview_gif;
  }

  [Serializable]
  public class GiphyImageData
  {
    [SerializeField] private int height;
    [SerializeField] private int width;
    [SerializeField] private int size;
    [SerializeField] private string hash;
    [SerializeField] private string url;
    [SerializeField] private string mp4;
    [SerializeField] private int mp4_size;
    [SerializeField] private string webp;
    [SerializeField] private int webp_size;

    public int Height => height;
    public int Width => width;
    public int Size => size;
    public string Hash => hash;
    public string Url => url;
    public string Mp4 => mp4;
    public int Mp4Size => mp4_size;
    public string Webp => webp;
    public int WebpSize => webp_size;
  }
}