using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gamehasended = false;
    public static int gameScore;
    float timer = 30;
    public Text timerText;

    public void Endgame ()
    {
        if(gamehasended == false)
        {
            gameScore = FindObjectOfType<ControllerScript>().score;
            gamehasended = true;
            FindObjectOfType<ControllerScript>().PlayOof();
            Restart();
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("n2");
        if(timer <= 0 & gamehasended == false)
        {
            Endgame();
        }
    }
}
