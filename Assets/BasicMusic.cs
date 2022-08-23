using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMusic : MonoBehaviour
{
    public static BasicMusic basicMusicInstance;

    public AudioSource[] trackList = new AudioSource[2];
    public int track;
    public bool thisInstance = false;
    public AudioSource currentTrack;

    public void awake()
    {
        if (basicMusicInstance != this && thisInstance == false)
        {
            basicMusicInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        if (basicMusicInstance == this)
        {
            return;
        }
        if (basicMusicInstance != this && thisInstance == true)
        {
            Destroy(gameObject);
        }
    }


    public void PlaySound()
    {
        currentTrack = trackList[track];
        for (int i = 0; i > 2; i++)
        {
            if (track == i)
            {

                currentTrack.Play();
            }
        }
    }
}
