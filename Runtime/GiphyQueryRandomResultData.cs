using System;

namespace Gameframe.Giphy
{
  [Serializable]
  public class GiphyQueryRandomResult
  {
    public GiphyQueryRandomResultData data;
    public GiphyQueryMetaData meta;
  }

  [Serializable]
  public class GiphyQueryRandomResultData : GiphyQueryCommonResultData
  {
    public GiphyGifResultImagesData images;

    public string image_original_url;
    public string image_url;
    public string image_mp4_url;
    public int image_frames;
    public int image_width;
    public int image_height;
        
    public string fixed_height_downsampled_url;
    public int fixed_height_downsampled_width;
    public int fixed_height_downsampled_height;

    public string fixed_width_downsampled_url;
    public int fixed_width_downsampled_width;
    public int fixed_width_downsampled_height;

    public string fixed_height_small_url;
    public string fixed_height_small_still_url;
    public int fixed_height_small_width;
    public int fixed_height_small_height;
        
    public string fixed_width_small_url;
    public string fixed_width_small_still_url;
    public int fixed_width_small_width;
    public int fixed_width_small_height;

    public string caption;
  }
}