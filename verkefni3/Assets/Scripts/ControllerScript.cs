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
        Cursor.visible = false;//lagar cursor
        Screen.lockCursor = true;
    }
    public void PlayOof()//spilar bara hljóð
    {
        deathAudio.clip = clipsound;
        deathAudio.Play();
    }
    public void Pew() // spilar líka hljóð
    {
        deathAudio.clip = pewpew;
        deathAudio.Play();
    }
}
