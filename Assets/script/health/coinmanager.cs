
using UnityEngine;
using TMPro;


public class coinmanager : MonoBehaviour
{

    private string coinKey = "playercoin";
    public static coinmanager instance;
    public TextMeshProUGUI text;
   
     int score;
    // Start is called before the first frame update
    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        Load();
    }

    public void changescore(int coinvalue)
    {
        score += coinvalue;
        soundmanager.instance.playsound("coin", 1f);
        text.text = score.ToString();
          
    Save();

    }
    public void Save()
    {
        PlayerPrefs.SetInt(coinKey, score);
        PlayerPrefs.Save();
    }

    public void Load()
    {
        if (PlayerPrefs.HasKey(coinKey))
        {
            score = PlayerPrefs.GetInt(coinKey);
        }
        else
        {
            score = 0;
        }
        text.text = score.ToString();
       
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteKey(coinKey);
    }
   
}
