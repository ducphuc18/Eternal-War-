using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class uimanager : MonoBehaviour
{

    public GameObject bgsounds;
    public GameObject startgamesounds;
    public GameObject gameoversounds;
    public bool chuyenman = false;
    public static uimanager instance;
    [SerializeField] GameObject tamdung;
    [SerializeField] GameObject gameover;
    [SerializeField] GameObject wingam;
    public TextMeshProUGUI text2;

    //[SerializeField] GameObject mau, coin;
    private void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
        }    
    }
    

    public void gameover1()
    {
        bgsounds.SetActive(false);
        gameoversounds.SetActive(true);

        gameover.SetActive(true);
        Time.timeScale = 0f;
      
    }    
    public void pausedgame()//tamdung
    {

        bgsounds.SetActive(false);
        startgamesounds.SetActive(true);
        tamdung.SetActive(true);
        Time.timeScale = 0f;
        
    }
    public void restart()
    {
        tamdung.SetActive(false);
        Time.timeScale = 1f;
        bgsounds.SetActive(true);
        startgamesounds.SetActive(false);

    }
    public void mainmenu()
    {
        startgamesounds.SetActive(false);
        bgsounds.SetActive(false);
        gameoversounds.SetActive(false);
        SceneManager.LoadScene("startgame");
        Time.timeScale = 1f;
        
    }
    public void quit()
    {
        Application.Quit();
    }
    public void lv1()
    {
        
        SceneManager.LoadScene("lv1");
        PlayerPrefs.DeleteAll();
    }
    public void wingame()
    {
        bgsounds.SetActive(false);
        startgamesounds.SetActive(true);
        wingam.SetActive(true);
        text2.text = coinmanager.instance.text.text;
        
    }
}
