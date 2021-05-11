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
    private bool isDataManagerDefined = false;
    public Sprite Goblin;
    public Sprite Ork;
    public Sprite GNoll;
    public Sprite Wyvern;
    public Sprite Wolf;
    public Sprite Boar;
    public void Initialize(string thisname)
    {   
        enemyname = thisname;
        if (!isDataManagerDefined)
        {
            dataManager = new DataManager();
            isDataManagerDefined = true;
        }
        choice = dataManager.giveChoice(enemyname);
        choiceManager = choiceManagerObject.GetComponent<ChoiceManager>();
        choiceManager.SetChoice(choice);
        switch (thisname)
        {
            case "Goblin":
                gameObject.GetComponent<SpriteRenderer>().sprite = Goblin;
                break;
            case "Ork":
                gameObject.GetComponent<SpriteRenderer>().sprite = Ork;
                break;
            case "GNoll":
                gameObject.GetComponent<SpriteRenderer>().sprite = GNoll;
                break;
            case "Wyvern":
                gameObject.GetComponent<SpriteRenderer>().sprite = Wyvern;
                break;
            case "Wolf":
                gameObject.GetComponent<SpriteRenderer>().sprite = Wolf;
                break;
            case "Boar":
                gameObject.GetComponent<SpriteRenderer>().sprite = Boar;
                break;
            default:
                gameObject.GetComponent<SpriteRenderer>().sprite = Goblin;
                break;
        }
    }
}

