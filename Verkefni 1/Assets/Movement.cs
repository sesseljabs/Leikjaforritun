using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            rb.AddForce(500*Time.fixedDeltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.AddForce(-500*Time.fixedDeltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.AddForce(0,0,500*Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            rb.AddForce(0,0,-500*Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.Space)) {
            rb.AddForce(0,1000*Time.fixedDeltaTime,0);
        }
    }
}
