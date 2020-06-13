using System;
using UnityEngine;

namespace Gameframe.Giphy
{
  [Serializable]
  public class GiphyQueryRandomResult
  {
    [SerializeField] private GiphyQueryRandomResultData data;
    [SerializeField] private GiphyQueryMetaData meta;

    public GiphyQueryRandomResultData Data => data;
    public GiphyQueryMetaData Meta => meta;
  }

  [Serializable]
  public class GiphyQueryRandomResultData : GiphyQueryCommonResultData
  {
    [SerializeField] private GiphyGifResultImagesData images;

    [SerializeField] private string image_original_url;
    [SerializeField] private string image_url;
    [SerializeField] private string image_mp4_url;
    [SerializeField] private int image_frames;
    [SerializeField] private int image_width;
    [SerializeField] private int image_height;

    [SerializeField] private string fixed_height_downsampled_url;
    [SerializeField] private int fixed_height_downsampled_width;
    [SerializeField] private int fixed_height_downsampled_height;

    [SerializeField] private string fixed_width_downsampled_url;
    [SerializeField] private int fixed_width_downsampled_width;
    [SerializeField] private int fixed_width_downsampled_height;

    [SerializeField] private string fixed_height_small_url;
    [SerializeField] private string fixed_height_small_still_url;
    [SerializeField] private int fixed_height_small_width;
    [SerializeField] private int fixed_height_small_height;

    [SerializeField] private string fixed_width_small_url;
    [SerializeField] private string fixed_width_small_still_url;
    [SerializeField] private int fixed_width_small_width;
    [SerializeField] private int fixed_width_small_height;

    [SerializeField] private string caption;

    public GiphyGifResultImagesData Images => images;
    public string ImageOriginalUrl => image_original_url;
    public string ImageUrl => image_url;
    public string ImageMp4Url => image_mp4_url;
    public int ImageFrames => image_frames;
    public int ImageWidth => image_width;
    public int ImageHeight => image_height;

    public string FixedHeightDownsampledUrl => fixed_height_downsampled_url;
    public int FixedHeightDownsampledWidth => fixed_height_downsampled_width;
    public int FixedHeightDownsampledHeight => fixed_height_downsampled_height;
    public string FixedWidthDownsampledUrl => fixed_width_downsampled_url;
    public int FixedWidthDownsampledWidth => fixed_width_downsampled_width;
    public int FixedWidthDownsampledHeight => fixed_width_downsampled_height;
    public string FixedHeightSmallUrl => fixed_height_small_url;
    public string FixedHeightSmallStillUrl => fixed_height_small_still_url;
    public int FixedHeightSmallWidth => fixed_height_small_width;
    public int FixedHeightSmallHeight => fixed_height_small_height;
    public string FixedWidthSmallUrl => fixed_width_small_url;
    public string FixedWidthSmallStillUrl => fixed_width_small_still_url;
    public int FixedWidthSmallWidth => fixed_width_small_width;
    public int FixedWidthSmallHeight => fixed_width_small_height;
    public string Caption => caption;
  }
}