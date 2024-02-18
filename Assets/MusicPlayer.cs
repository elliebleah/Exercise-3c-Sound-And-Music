using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip musicClip; // Assign your music clip in the Unity Editor
    private AudioSource musicSource;

    void Start()
    {
        // Create an AudioSource component and set up looping
        musicSource = gameObject.AddComponent<AudioSource>();
        musicSource.clip = musicClip;
        musicSource.loop = true;

        // Play the music
        musicSource.Play();
    }
}
