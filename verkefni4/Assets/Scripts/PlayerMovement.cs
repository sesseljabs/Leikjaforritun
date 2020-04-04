using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Movement controller;
    float move = 0f;
    public Animator animator;
    public float runSpeed = 40f;
    bool jumping = false;
    bool crouch = false;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Gem")
        {
            Destroy(collider.gameObject);
        }
    }
    public void OnLanding()
    {
        animator.SetBool("isjumping", false);
    }
    public void OnCrouching(bool penis)
    {
        Debug.Log(penis);
        animator.SetBool("isCrouching", penis);
    }
    void Update()
    {
        move = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("speed", Mathf.Abs(move));
        if (Input.GetButtonDown("Jump"))
        {
            jumping = true;
            animator.SetBool("isjumping", true);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        controller.Move(move*Time.fixedDeltaTime, crouch, jumping);
        jumping = false;
    }
}
