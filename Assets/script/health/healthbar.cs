using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    
    [SerializeField] private playerheart playerheath;
    [SerializeField] private  Image totalhealthbar;
    [SerializeField] private Image curenthealthbar;

  
    private void Awake()
    {
        playerheath.currenthealth = 20f;
    }
    private void Start()
    {
        
        totalhealthbar.fillAmount = playerheath.startinghealth/20;
        
    }
   
    private void Update()
    {
        
        curenthealthbar.fillAmount = playerheath.currenthealth/20;
       

    }


}
