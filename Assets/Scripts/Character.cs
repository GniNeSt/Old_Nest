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
        choice_first.sentence = "first";
        choice_second.sentence = "second";
        choice_third.sentence = "third";
        choice_fourth.sentence = "fourth";
        player = GameObject.FindWithTag("Player");
        Debug.Log(player.transform.Find("Choices").transform.GetChild(0).name);
        player.transform.Find("Choices").transform.GetChild(0).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice_first.sentence + GroundManager.poscount.ToString();
        player.transform.Find("Choices").transform.GetChild(1).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice_second.sentence + GroundManager.poscount.ToString();
        player.transform.Find("Choices").transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice_third.sentence + GroundManager.poscount.ToString();
        player.transform.Find("Choices").transform.GetChild(3).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice_fourth.sentence + GroundManager.poscount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
