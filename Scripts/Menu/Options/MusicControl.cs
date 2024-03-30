using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicControl : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void Control (float sliderMusic)
    {
        audioMixer.SetFloat("MusicVolume", Mathf.Log10(sliderMusic) * 20);
    }
}
