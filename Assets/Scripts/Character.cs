using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string enemyname = "Goblin";
    public Choice choice = new Choice();
    public GameObject choiceManagerObject;
    private ChoiceManager choiceManager;
    public DataManager dataManager;
    public void Initialize(string thisname)
    {   
        enemyname = thisname;
        dataManager = new DataManager();
        choice = dataManager.giveChoice(enemyname);
        choiceManager = choiceManagerObject.GetComponent<ChoiceManager>();
        choiceManager.SetChoice(choice);
    }
}

