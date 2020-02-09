using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public Text levelNumber;

    public void CompleteLevel()
    {
        int number = SceneManager.GetActiveScene().buildIndex;
        levelNumber.text = number.ToString();
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   } 
