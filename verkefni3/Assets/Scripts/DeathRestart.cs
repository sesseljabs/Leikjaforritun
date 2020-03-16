using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathRestart : MonoBehaviour //skrifta sem er á lokaskjánum
{
    int score;//stigin
    public Text stigatexti;//textinn sem sýnir stig
    void Start()
    {
        Cursor.visible = true;//lagar cursor
        Screen.lockCursor = false;
        GameObject temp = GameObject.Find("GameManager");//Finnur Game manager
        GameManager points = temp.GetComponent<GameManager>();//sækir gamemanager skriftuna
        score = GameManager.gameScore;//sækir stigin sem eru geymd í skriftunni
        stigatexti.text = score.ToString() + " stig"; // setur stigin á skjáinn
    }
    public void OpenLastScene()
    {//opnar senuna á undan (byrjar leikinn uppá nýtt)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void QuitGame()
    {//hættir í leiknum
        Application.Quit();
    }
}
