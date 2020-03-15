using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public Text score;
    //public Text uwu = score.GetComponent<Text>();
    public int counter;
    void Start()
    {
        score = GameObject.Find("ScoreText").GetComponent<Text>();
        counter = FindObjectOfType<ControllerScript>().score;
    }
    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
        if (col.gameObject.tag == "Obstacle" || col.gameObject.tag == "goldcube") {
            FindObjectOfType<ControllerScript>().score++;
            counter++;
            if(col.gameObject.tag == "goldcube") { FindObjectOfType<ControllerScript>().score+=2; counter+=2; }
            score.text = counter.ToString();
            Destroy(col.gameObject);
        }
    }
}
