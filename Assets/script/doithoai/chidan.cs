using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class chidan : MonoBehaviour
{
    
    public TextMeshProUGUI textcomponent;
    public string[] slines;
    public float speed;
    private int index;

    private void Awake()
    {
        gameObject.SetActive(false);
    }
    private void Start()
    {

        playermovement.instance.playermovement1 = false;
       
        textcomponent.text = string.Empty;
        sartdialogue();

    }
    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (textcomponent.text == slines[index])
            {
                nextline();

            }
            else
            {
                StopAllCoroutines();
                textcomponent.text = slines[index];
            }
        }
    }
    void sartdialogue()
    {
        index = 0;
        StartCoroutine(typelines());
    }
    IEnumerator typelines()
    {
        foreach (var c in slines[index].ToCharArray())
        {
            textcomponent.text += c;
            yield return new WaitForSeconds(speed);


        }
    }
    void nextline()
    {
        if (index < slines.Length - 1)
        {

            index++;
            textcomponent.text = string.Empty;
            StartCoroutine(typelines());
        }
        else
        {
            gameObject.SetActive(false);
            playermovement.instance.playermovement1 = true;
           
        }
    }
   
}
