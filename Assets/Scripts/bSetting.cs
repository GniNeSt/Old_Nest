using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bSetting : MonoBehaviour
{
    private SpriteRenderer spriterenderer;
    private BoxCollider2D boxCollider2D,first,second,third,fourth,ment;
    private Canvas canvas;
    bool isClicked;
    public Slider slider;
    public AudioSource audioSource;
    public TMPro.TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = GameObject.Find("SettingCover").GetComponent<SpriteRenderer>();
        boxCollider2D = GameObject.Find("Settings").GetComponent<BoxCollider2D>();
        canvas = GameObject.Find("SettingUICanvas").GetComponent<Canvas>();
        first = GameObject.Find("first").GetComponent<BoxCollider2D>();
        second = GameObject.Find("second").GetComponent<BoxCollider2D>();
        third = GameObject.Find("third").GetComponent<BoxCollider2D>();
        fourth = GameObject.Find("fourth").GetComponent<BoxCollider2D>();
        ment = GameObject.Find("Ment").GetComponent<BoxCollider2D>();
        isClicked = false;
        spriterenderer.enabled = isClicked;
        boxCollider2D.enabled = isClicked;
        canvas.enabled = isClicked;
        slider.value = (float)1;
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = slider.value;
        textMeshPro.text = "음악 볼륨: " + ((int)(slider.value * 100)).ToString();
    }

    public void toggleSetting()
    {
        isClicked = !isClicked;
        spriterenderer.enabled = isClicked;
        boxCollider2D.enabled = isClicked;
        canvas.enabled = isClicked;
        first.enabled = !isClicked;
        second.enabled = !isClicked;
        third.enabled = !isClicked;
        fourth.enabled = !isClicked;
        ment.enabled = !isClicked;
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
