using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMusicScenes : MonoBehaviour
{
    public void AlsoSprachZarathustra()
    {
        SceneManager.LoadScene("Also_Sprach_Zarathustra");
    }
    public void TheFlightOfTheBumbeblee()
    {
        SceneManager.LoadScene("The_Flight_Of_The_Bumblebee");
    }

    public void TheFinlaCountDown()
    {
        SceneManager.LoadScene("The_Final_Countdown");
    }
}
