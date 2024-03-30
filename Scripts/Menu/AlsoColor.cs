using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlsoColor : MonoBehaviour
{
    public string WinAlso;

    public Button button;

    public Color newColor;

    private void Start()
    {
        WinAlso = PlayerPrefs.GetString("WinAlso");
    }

    private void Update()
    {
        Image buttonImage = button.GetComponent<Image>();

        if (WinAlso == "Also")
        {
            buttonImage.color = newColor;
        }
    }
}
