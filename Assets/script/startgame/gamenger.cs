
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.SocialPlatforms.Impl;


public class gamenger : MonoBehaviour
{
    public GameObject player;
   
    
    private void Awake()
    {
        //player.GetComponent<playerheart>().LoadHealth();
        
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("player"))
        {
          
            SceneManager.LoadScene("lv2");
            
        }    
       
    }

   
}
