using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string enemyname = "Goblin";
    public Choice choice = new Choice();
    private Choice cnew = new Choice();
    public GameObject choicemanager;
    public DataManager dataManager;
    void Start()
    {   
        dataManager = new DataManager();
        choice = dataManager.data.Goblin;
        choicemanager.transform.GetChild(0).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.first;
        choicemanager.transform.GetChild(1).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.second;
        choicemanager.transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.third;
        choicemanager.transform.GetChild(3).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.fourth;
    }
}

