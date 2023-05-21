using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class soundmanager : MonoBehaviour
{
    public static soundmanager instance;
    public bool ismute = false;
    private AudioSource auddioSource;
    public AudioClip[] sounds;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
           
        }    
       
       
    }
    private void Start()
    {
        auddioSource = GetComponent<AudioSource>();
    }
    public void playsound(string sound, float volume)
    {
        if(!ismute)
        {
            switch(sound)
            {
                case "chem":
                    auddioSource.PlayOneShot(sounds[0],volume); break;
                case "hurt":
                    auddioSource.PlayOneShot(sounds[1], volume); break;
                case "coin":
                    auddioSource.PlayOneShot(sounds[2], volume); break;
                case "mau":
                    auddioSource.PlayOneShot(sounds[3], volume); break;
               
            }
        }    
    } 
      
}
