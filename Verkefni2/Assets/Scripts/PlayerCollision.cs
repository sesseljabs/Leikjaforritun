using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Text scoretext;
    public int score = 0;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        if(col.collider.tag == "Coin")
        {
            Debug.Log(col.collider.tag);
            Destroy(col.collider.gameObject);
            //score++;
            scoretext.text = "penis";
        }
        if(col.collider.tag == "Done")
        {
            Debug.Log(col.collider.tag);
            scoretext.text = "ur gay";
        }
        scoretext.text = score.ToString();
    }
}
