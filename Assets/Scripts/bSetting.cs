using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bSetting : MonoBehaviour
{
    bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleSetting()
    {
        isClicked = !isClicked;
        if (isClicked)
        {
            Time.timeScale = 0;
            Debug.Log("멈춰!");
        }
        else
        {
            Time.timeScale = 1;
            Debug.Log("움직여!");
        }
    }
}
