using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBackCountDown : MonoBehaviour
{
    public void Back()
    {
        Debug.Log("polla");
        SceneManager.LoadScene("Menu");
        
    }
}
