using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelect : MonoBehaviour
{
    public void StartGame()
    {//sækir lika næstu senu nema fyrir menuið
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
