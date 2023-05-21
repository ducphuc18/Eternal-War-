using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundlevel2 : MonoBehaviour
{
    public static soundlevel2 instance;
    private AudioSource Source;

    private void Awake()
    {
        instance = this;
        Source = GetComponent<AudioSource>();
    }
    public void PlaySound(AudioClip _sound)
    {
        Source.PlayOneShot(_sound);
    }
}
