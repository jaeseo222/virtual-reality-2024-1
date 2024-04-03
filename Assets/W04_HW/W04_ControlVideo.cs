using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class W04_ControlVideo : MonoBehaviour
{
    public VideoPlayer player;

    void Start()
    {
        player.Stop();
    }

    void VideoPlay()
    {
        player.Play();
    }

    void VideoStop()
    {
        player.Stop();
    }

    public void OnClick_Play()
    {
        VideoPlay();
    }

    public void OnClick_Stop()
    {
        VideoStop();
    }
}
