using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasended = false;
    public void Endgame ()
    {
        if(gamehasended == false)
        {
            gamehasended = true;
            FindObjectOfType<ControllerScript>().PlayOof();
            Debug.Log("Game over");
            Restart();
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
