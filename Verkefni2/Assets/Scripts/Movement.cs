//using UnityEngine;


//public class Movement : MonoBehaviour
//{/*
/*
    float speed = 10;
    float gravity = 50;
    Rigidbody rb;
    Vector3 moveDir = Vector3.zero;
    Vector3 velocity = Vector3.zero;
    CharacterController controller;
    //Animator anim;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        //anim = GetComponent<Animator>();
    }

    void Update()
    {

        
        moveDir = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveDir.x = -1 * speed; 
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            moveDir.x = 0;
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveDir.x = 1 * speed;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            moveDir.x = 0; ;
            moveDir *= speed;
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveDir.z = 1 * speed;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            moveDir.z = 0;
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveDir.z = -1 * speed;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            moveDir.z = 0;
        }


        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            moveDir.y = 100;
            Debug.Log("forward");
        }
        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                velocity.y =  20;
            }
        }
        if (!controller.isGrounded)
        {
            velocity.y -= gravity * Time.deltaTime;
        }
        controller.Move(velocity * Time.deltaTime);
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }

    *//*
    Rigidbody rb;
    public float movementSpeed = 6.0f;
    public bool isGrounded = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Ground"))// && isGrounded == false)
        {
            isGrounded = true;
            Debug.Log("grounded");
        }
    }

    void FixedUpdate()
        {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("jumped");
            rb.AddForce(new Vector3(0, 13, 0), ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.position += transform.right * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position += -transform.right * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += -transform.forward * movementSpeed * Time.deltaTime;
        }
        Debug.Log(isGrounded);

    }
}
    /*

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    public bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Ground") && isGrounded == false)
        {
            isGrounded = true;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("jumped");
            rb.AddForce(new Vector3(0, 500, 0), ForceMode.Impulse);
            isGrounded = false;
        }
    }
}*/
//}*/
using UnityEngine;

public class Movement : MonoBehaviour
{
    Transform player;
    Rigidbody rb;
    GameObject pl;
    bool grounded;
    public float Force;
    public float JumpForce;

    public void Grounded()
    { // Runnar þegar player collidar við ground
        grounded = true;
        Debug.Log("Grounded");
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GetComponent<Transform>();
    }
    void FixedUpdate()
    {

        // Hreyfingin

        if (Input.GetKey("space") && grounded == true)
        { // Að hoppa
            Debug.Log("Jumped");
            grounded = false;
            rb.AddForce(0, JumpForce * Time.deltaTime, 0, ForceMode.Impulse);
        }
        // movement
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(0, 0, Force * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(0, 0, -Force * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(-Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
