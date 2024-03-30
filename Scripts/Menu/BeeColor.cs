using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeeColor : MonoBehaviour
{
    public string WinBee;

    public Button button;

    public Color newColor;

    private void Start()
    {
        WinBee = PlayerPrefs.GetString("WinBee");
    }

    private void Update()
    {
        Image buttonImage = button.GetComponent<Image>();

        if (WinBee == "Bee")
        {
            buttonImage.color = newColor;
        }
    }
}
