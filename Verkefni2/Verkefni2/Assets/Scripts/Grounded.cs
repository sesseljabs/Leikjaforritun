using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    public Movement player;
    //gáir hvort playerinn hafi collidað við eitthvað
    public void OnCollisionEnter(Collision col)
    {
        player.Grounded();
    }
    void OnCollisionExit(Collision hit)
    {// gáir hvort player hafi hætt að collida við eitthvað
        player.UnGround();
    }
}
