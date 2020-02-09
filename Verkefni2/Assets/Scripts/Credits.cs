using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit()
    {//hættir í leiknum
        Application.Quit();
        Debug.Log("Quit");
    }
    
}
