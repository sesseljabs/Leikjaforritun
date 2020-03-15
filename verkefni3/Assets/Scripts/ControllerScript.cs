using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public AudioSource deathAudio;
    public AudioClip clipsound;
    public AudioClip pewpew;
    public int score = 0;
    void Start()
    {
        deathAudio = GetComponent<AudioSource>();
    }
    public void PlayOof()
    {
        deathAudio.clip = clipsound;
        deathAudio.Play();
    }
    public void Pew()
    {
        deathAudio.clip = pewpew;
        deathAudio.Play();
    }
}
