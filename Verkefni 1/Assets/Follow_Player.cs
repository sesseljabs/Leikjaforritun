﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public Transform player;
    public Vector3 offset; 

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position+offset;
    }
}
