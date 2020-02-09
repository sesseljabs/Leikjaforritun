using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Update()
    {// fyrir krónu að snúast, bara snýr henni alltaf
        transform.Rotate(0, 0, 60 * Time.deltaTime);
    }
}
