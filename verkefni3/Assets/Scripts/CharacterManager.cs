using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public AudioSource deathAudio;
    void Start()
    {
        deathAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(transform.position.y < 30)
        {// ef hluturinn fer undir hnitið 30 er leikurinn búinn
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
