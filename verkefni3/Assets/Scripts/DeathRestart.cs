using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathRestart : MonoBehaviour
{
    int score;
    public Text stigatexti;
    void Start()
    {
        Cursor.visible = true;
        Screen.lockCursor = false;
        GameObject temp = GameObject.Find("GameManager");
        GameManager points = temp.GetComponent<GameManager>();
        score = GameManager.gameScore;
        stigatexti.text = score.ToString() + " stig";
    }
    public void OpenLastScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
