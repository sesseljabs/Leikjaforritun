using UnityEngine;


public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float movementSpeed = 6.0f;
    public bool grounded = true;
    public float JumpForce;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Grounded()
    { // Runnar þegar player collidar við eitthvað
        grounded = true;
    }
    public void UnGround()
    { // runnar þegar hann hættir að collida við eitthvað
        grounded = false;
    }

    void FixedUpdate()
        {
        if (Input.GetKey(KeyCode.Space) && grounded == true)
        { // Að hoppa
            grounded = false;
            rb.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.UpArrow)){//hreyfa áfram
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow)){// hreyfa til hægri
            transform.position += transform.right * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow)){// hreyfa til vinstri
            transform.position += -transform.right * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow)){// hreyfa afturábak
            transform.position += -transform.forward * movementSpeed * Time.deltaTime;
        }
        if(transform.position.y < -2)// ef hann hoppar útaf byrjar uppá nýtt
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}