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
    
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("penis");
    }

    void Update()
    {
        if(transform.position.y < 30)
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
