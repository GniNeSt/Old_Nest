using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string script;
    public Choice choice_first = new Choice();
    public Choice choice_second = new Choice();
    public Choice choice_third = new Choice();
    public Choice choice_fourth = new Choice();
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        choice_first.sentence = "first"  + GroundManager.poscount.ToString();;
        choice_second.sentence = "second"  + GroundManager.poscount.ToString();;
        choice_third.sentence = "third" + GroundManager.poscount.ToString();;
        choice_fourth.sentence = "fourth" + GroundManager.poscount.ToString();;
        player = GameObject.FindWithTag("Player");
        player.transform.Find("Choices").transform.GetChild(0).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice_first.sentence;
        player.transform.Find("Choices").transform.GetChild(1).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice_second.sentence;
        player.transform.Find("Choices").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice_third.sentence;
        player.transform.Find("Choices").transform.GetChild(3).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice_fourth.sentence;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
