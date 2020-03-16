using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gamehasended = false;
    public static int gameScore;//stigin sem leikmaður hefur fengið, er static til að geta náð í í næstu senu líka
    public float timer = 30;//tíminn sem leikmaður hefur
    public Text timerText; //textinn sem synir tímann

    public void Endgame ()//Runnar þegar leikur endar en bara einu sinni
    {
        if(gamehasended == false)
        {
            gameScore = FindObjectOfType<ControllerScript>().score; // sækir stigin úr annari skriftu
            gamehasended = true;
            FindObjectOfType<ControllerScript>().PlayOof(); // spilar hljóð (virkar sjaldan)
            Restart();
        }
    }
    public void Restart()
    {//opnar næstu senu sem er endasenan
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void Update()
    {
        timer -= Time.deltaTime;// heldur utanum texta
        timerText.text = timer.ToString("n2"); // setur textann á skjáinn með 2 aukastöfum
        if(timer <= 0 & gamehasended == false) // þegar hann er kominn á núll endar leikurinn
        {
            Endgame();
        }
    }
}
