
using UnityEngine;


public class playerheart : MonoBehaviour
{
   
    public static playerheart instance;
    private string healthKey = "playerHealth";
    public float startinghealth = 20f;
    public float currenthealth; //{ get; private set; }
    private Animator amin;
    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        currenthealth = startinghealth;
        amin = GetComponent<Animator>();
    }

    private void Start()
    {
        LoadHealth();
    }

    public void takedamage(float _damage)
    {
        
        currenthealth = Mathf.Clamp(currenthealth - _damage, 0, startinghealth);
       
        if (currenthealth > 0)
        {
            soundmanager.instance.playsound("hurt", 1f);
            amin.SetTrigger("hurt");
            
        }
        else if (currenthealth == 0)
        {
            amin.SetTrigger("die");

            GetComponent<playermovement>().enabled = false;
            gameObject.SetActive(false);
            uimanager.instance.gameover1();
            
        }
        SaveHealth();

    }
    public void addhealth(float _value)
    {
       
        currenthealth = Mathf.Clamp(currenthealth + _value, 0, startinghealth);
        soundmanager.instance.playsound("mau", 1f);
        SaveHealth();
    }
    public void SaveHealth()
    {
       
        PlayerPrefs.SetFloat(healthKey, currenthealth);
        PlayerPrefs.Save();
    }

    public void LoadHealth()
    {


        if (PlayerPrefs.HasKey(healthKey))
        {
            currenthealth = PlayerPrefs.GetFloat(healthKey);
        }
        else
        {
            currenthealth = startinghealth;
        }
       
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteKey(healthKey);
    }
   


}
