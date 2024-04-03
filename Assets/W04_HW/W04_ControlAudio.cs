using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W04_ControlAudio : MonoBehaviour
{
    public AudioSource player;

    void Start()
    {
        player.Stop();
    }

    void AudioPlay()
    {
        player.Play();
    }

    void AudioStop()
    {
        player.Stop();
    }

    public void OnClick_Play()
    {
        AudioPlay();
    }

    public void OnClick_Stop()
    {
        AudioStop();
    }
}
