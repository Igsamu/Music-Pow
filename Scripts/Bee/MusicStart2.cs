using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStart2 : MonoBehaviour
{
    public AudioClip music;
    public float retraso = 5.5f;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = music;
        audioSource.PlayDelayed(retraso);
    }
}
