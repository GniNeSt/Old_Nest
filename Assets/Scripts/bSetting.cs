using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bSetting : MonoBehaviour
{
    private SpriteRenderer spriterenderer;
    private BoxCollider2D boxCollider2D;
    private TMPro.TextMeshProUGUI textMeshPro;
    bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = GameObject.Find("SettingCover").GetComponent<SpriteRenderer>();
        boxCollider2D = GameObject.Find("Settings").GetComponent<BoxCollider2D>();
        textMeshPro = GameObject.Find("SettingMentTMP").GetComponent<TMPro.TextMeshProUGUI>();
        isClicked = false;
        spriterenderer.enabled = isClicked;
        boxCollider2D.enabled = isClicked;
        textMeshPro.enabled = isClicked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleSetting()
    {
        isClicked = !isClicked;
        spriterenderer.enabled = isClicked;
        boxCollider2D.enabled = isClicked;
        textMeshPro.enabled = isClicked;
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
