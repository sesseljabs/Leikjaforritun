using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public Text score;//stigin
    //public Text uwu = score.GetComponent<Text>();
    public int counter;
    void Start()
    {
        score = GameObject.Find("ScoreText").GetComponent<Text>();//finnur stig og eitthvað
        counter = FindObjectOfType<ControllerScript>().score;
    }
    void OnCollisionEnter(Collision col) // þegar kúlan klessir á eitthvað
    {
        Destroy(gameObject);//skemmist kúlan
        if (col.gameObject.tag == "Obstacle" || col.gameObject.tag == "goldcube") { // ef það sem klesst var á er með þessi tags:
            FindObjectOfType<ControllerScript>().score++; // stigin eru hækkuð, ef það er goldcube hækkat meira
            counter++;
            if(col.gameObject.tag == "goldcube") { FindObjectOfType<ControllerScript>().score+=2; counter+=2; }
            score.text = counter.ToString(); // textinn á skjánum sett sem stig
            Destroy(col.gameObject);//hlutinum er eytt
        }
    }
}
