using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {//lagar cursor svo hann trufli ekki
        Cursor.visible = true;
        Screen.lockCursor = false;
    }
    public void StartGame()
    {// loadar næsta scenei
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {//hættir í leiknum
        Application.Quit();
    }
}
