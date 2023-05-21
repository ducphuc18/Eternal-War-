using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class savesystem : MonoBehaviour
{
    public string playerhealthkey = "playerhealth";
    public playerheart playerheart;
    private healthbar healthbar;
    private int mau;
    [SerializeField] private Image curenthealthbar;

    private void Awake()
    {
        playerheart = GetComponent<playerheart>();
        healthbar = GetComponent<healthbar>();
        mau = PlayerPrefs.GetInt(playerhealthkey);
        playerheart.currenthealth = mau;
        Debug.Log(mau + "hggh");
        curenthealthbar.fillAmount = mau / 10;


    }
    private void Update()
    {
        save();
    }

    public void save()
    {
        playerheart.currenthealth = mau;
        PlayerPrefs.SetInt(playerhealthkey,mau);
        
    }


}