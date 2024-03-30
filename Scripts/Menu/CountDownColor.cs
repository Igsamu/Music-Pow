using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownColor : MonoBehaviour
{
    public string WinCountDown;

    public Button button;

    public Color newColor;

    private void Start()
    {
        WinCountDown = PlayerPrefs.GetString("WinCountDown");
    }

    private void Update()
    {
        Image buttonImage = button.GetComponent<Image>();

        if (WinCountDown == "CountDown")
        {
            buttonImage.color = newColor;
        }
    }
}
