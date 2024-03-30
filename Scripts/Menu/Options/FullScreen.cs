using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullScreen : MonoBehaviour
{
    public Toggle toggle;

    private void Start()
    {
        if(Screen.fullScreen)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }
    }

    public void FullScreenActivate(bool FullScreen)
    {
        Screen.fullScreen = FullScreen;
    }
}
