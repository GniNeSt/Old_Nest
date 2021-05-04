using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string enemyname = "Goblin";
    public Choice choice = new Choice();
    public GameObject choicemanager;
    public DataManager dataManager;
    public void Initialize(string thisname)
    {   
        enemyname = thisname;
        dataManager = new DataManager();
        choice = dataManager.giveChoice(enemyname);
        choicemanager.transform.GetChild(0).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.first.ment;
        choicemanager.transform.GetChild(1).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.second.ment;
        choicemanager.transform.GetChild(2).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.third.ment;
        choicemanager.transform.GetChild(3).transform.GetChild(0).GetComponent<TMPro.TextMeshPro>().text = choice.fourth.ment;
    }
}

