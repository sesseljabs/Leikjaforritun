using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public Text scoretext; // score texta objectið
    public int score = 0; // score talan

    void OnCollisionEnter(Collision col)
    { // þegar hann klessir á eitthvað
        if (col.collider.tag == "Coin") // ef það er taggað sem "coin" er bætt við scoreið
        {
            Debug.Log(col.collider.tag);
            Destroy(col.collider.gameObject); // eyðir krónunni
            score++; // hækkar score
            if(score > 5)
            {
                FindObjectOfType<GameManager>().CompleteLevel();
            }
        }
        scoretext.text = score.ToString()+"/6"; // setur töluna á textann
        if (col.collider.tag == "Done") // ef taggað sem "done"
        {
            FindObjectOfType<GameManager>().CompleteLevel(); // kallar á CompleteLevel í GameManagernum
        }
    }
}
