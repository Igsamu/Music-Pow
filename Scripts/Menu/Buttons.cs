using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
