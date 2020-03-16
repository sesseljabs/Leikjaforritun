using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float moveSpeed;
    public GameObject projectile;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))//ef ýtt er á músina er gerð ný kúla og henni skoitið af stað
        {
            FindObjectOfType<ControllerScript>().Pew();
            GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
            Rigidbody bulletRB;
            bulletRB = bullet.GetComponent<Rigidbody>();
            bulletRB.AddForce(transform.up * moveSpeed);
            Destroy(bullet, 5.0f); // eyðileggur kúluna eftir 5 sek ef hún er ekki ónýt
        }
    }
}
