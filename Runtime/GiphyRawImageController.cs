using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Gameframe.Giphy
{
    public class GiphyRawImageController : MonoBehaviour
    {
        [SerializeField] 
        private GiphyConfig config = null;
        
        [SerializeField] 
        private string searchQuery = "cheeseburger";
        
        [SerializeField] private VideoPlayer videoPlayer;
        [SerializeField] private RawImage rawImage;
        [SerializeField] private bool playOnEnable = true;
        [SerializeField] private AspectRatioMode aspectMode = AspectRatioMode.None;
        
        public enum AspectRatioMode
        {
            None,
            ActualSize,
            WidthControlsHeight,
            HeightControlsWidth
        }
        
        private void Awake()
        {
            if (videoPlayer != null)
            {
                videoPlayer.started += VideoPlayerOnStarted;
            }
        }

        private void OnDestroy()
        {
            if (videoPlayer != null)
            {
                videoPlayer.started -= VideoPlayerOnStarted;
            }
        }

        private void VideoPlayerOnStarted(VideoPlayer source)
        {
            Alpha = 1f;
        }

        private void OnEnable()
        {
            if (playOnEnable)
            {
                PlayRandom();
            }
        }
        
        private void SetImageSize(int width, int height)
        {
            var rect = (RectTransform)rawImage.transform;
            var size = rect.sizeDelta;

            switch (aspectMode)
            {
                case AspectRatioMode.None:
                    return;
                case AspectRatioMode.ActualSize:
                    size.x = width;
                    size.y = height;
                    break;
                case AspectRatioMode.WidthControlsHeight:
                    {
                        var ratio = Mathf.Clamp(width / (float)height, 1f / 1000f, 1000f);
                        size.y = size.x / ratio;
                        videoPlayer.aspectRatio = VideoAspectRatio.Stretch;
                    }
                    break;
                case AspectRatioMode.HeightControlsWidth:
                    {
                        var ratio = Mathf.Clamp(width / (float)height, 1f / 1000f, 1000f);
                        size.x = size.y * ratio;
                        videoPlayer.aspectRatio = VideoAspectRatio.Stretch;
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            rect.sizeDelta = size;
        }

        [ContextMenu("RandomQuery")]
        public async void PlayRandom()
        {
            if (config == null)
            {
                Debug.LogError("Config is null. Please create a GiphyConfig asset using the Create->Gameframe->Giphy->Config menu and assign it to the config variable",this);
                return;
            }
            
            if (string.IsNullOrEmpty(config.apiKey))
            {
                Debug.LogError("Giphy ApiKey is not configured. You must create a developer app and get an API key from the giphy developer website.",this);
                return;
            }
            
            Alpha = 0;
            var result = await GiphyQuery.Random(config, searchQuery);
            if (string.IsNullOrEmpty(result.data.image_mp4_url))
            {
                Debug.Log("No MP4 result");
                return;
            }

            int width = 0;
            int height = 0;
            
            videoPlayer.source = VideoSource.Url;

            if (videoPlayer.isLooping)
            {
                videoPlayer.url = result.data.images.looping.mp4;
                width = result.data.image_width;
                height = result.data.image_height;
            }
            else
            {
                videoPlayer.url = result.data.images.original_mp4.mp4;
                width = result.data.image_width;
                height = result.data.image_height;
            }
            
            SetImageSize(width,height);
            
            videoPlayer.Play();
        }

        private float Alpha
        {
            get => rawImage.color.a;
            set
            {
                var color = rawImage.color;
                color.a = value;
                rawImage.color = color;
            }
        }
        
        private void OnValidate()
        {
            if (videoPlayer == null)
            {
                videoPlayer = GetComponent<VideoPlayer>();
            }
            if (rawImage == null)
            {
                rawImage = GetComponent<RawImage>();
            }
        }
        
    }


}

