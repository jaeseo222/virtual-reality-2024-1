using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class W03_Lecture_ButtonController : MonoBehaviour
{
    public VideoPlayer player;

    void Start()
    {
        player.Stop();
    }

    void PlayVideo()
    {
        player.Play();
    }
    void StopVideo()
    {
        player.Stop();
    }

    public void OnClick_PlayVideo() {
        PlayVideo();
        print("play");
    }
    public void OnClick_StopVideo()
    {
        StopVideo();
        print("stop");

    }
}
