using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectbuttons : MonoBehaviour
{
    [SerializeField] private RectTransform[] options;

    private RectTransform rect;
    private int currentposition;
    private void Awake()
    {
        rect = GetComponent<RectTransform>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            changeposition(-1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            changeposition(1);
        }
       
        if(Input.GetKey(KeyCode.KeypadEnter))
        {
            interact();
        }    
    }
    private void changeposition(int _change)
    {
        currentposition += _change;

        if (options[currentposition].transform.position.y < 0)
        {
            currentposition = options.Length - 1;
        }
        else if (currentposition > options.Length - 1)
        {
            currentposition = 0;
        }
        rect.position = new Vector3(rect.position.x, options[currentposition].position.y, 0);
    }
    private void interact()
    {
        options[currentposition].GetComponent<Button>().onClick.Invoke();
    }
}
