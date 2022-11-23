using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class MyVideoPlayer : MonoBehaviour
{
    [SerializeField] private GameObject background;

    /// <summary>
    /// Path from streamingassets.
    /// </summary>
    [SerializeField] private string path;
    private VideoPlayer videoPlayer;

    private bool playing = false;

    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.url = Path.Combine(Application.streamingAssetsPath, path);
        videoPlayer.loopPointReached += VideoPlayerLoopPointReached;
    }

    private void VideoPlayerLoopPointReached(VideoPlayer source)
    {
        playing = false;
        background.SetActive(true);
    }

    public void OnClick()
    {
        background.SetActive(playing);
        playing = !playing;

        if (playing)
        {
            videoPlayer.Play();
            return;
        }
        videoPlayer.Pause();
    }
}