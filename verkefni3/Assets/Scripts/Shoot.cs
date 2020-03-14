﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float moveSpeed;
    public GameObject projectile;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            Rigidbody bulletRB;
            bulletRB = bullet.GetComponent<Rigidbody>();
            bulletRB.AddForce(transform.up * moveSpeed);
            Destroy(bullet, 10.0f);
        }
    }
}
