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
    public static bool isCompanion = false;
    public Sprite Goblin, Gnoll, Chicken, Wolf, Boar, Ork, 
                  GodStatue, Lake, Mimic, TreasureChest,
                  Archer, Knight, Mage, Warrior;
    public void Initialize(string thisname)
    {   
        enemyname = thisname;
        dataManager = new DataManager();
        choice = dataManager.giveChoice(enemyname);
        if (enemyname == "Archer" || enemyname == "Knight" || enemyname == "Warrior" || enemyname == "Mage")
            isCompanion = true;
        else
            isCompanion = false;
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
            case "Gnoll":
                gameObject.GetComponent<SpriteRenderer>().sprite = Gnoll;
                break;
            case "Chicken":
                gameObject.GetComponent<SpriteRenderer>().sprite = Chicken;
                break;
            case "Wolf":
                gameObject.GetComponent<SpriteRenderer>().sprite = Wolf;
                break;
            case "Boar":
                gameObject.GetComponent<SpriteRenderer>().sprite = Boar;
                break;
            case "GodStatue":
                gameObject.GetComponent<SpriteRenderer>().sprite = GodStatue;
                break;
            case "Lake":
                gameObject.GetComponent<SpriteRenderer>().sprite = Lake;
                break;
            case "Mimic":
                gameObject.GetComponent<SpriteRenderer>().sprite = Mimic;
                break;
            case "TreasureChest":
                gameObject.GetComponent<SpriteRenderer>().sprite = Mimic;
                break;
            case "Archer":
                gameObject.GetComponent<SpriteRenderer>().sprite = Archer;
                break;
            case "Knight":
                gameObject.GetComponent<SpriteRenderer>().sprite = Knight;
                break;
            case "Mage":
                gameObject.GetComponent<SpriteRenderer>().sprite = Mage;
                break;
            case "Warrior":
                gameObject.GetComponent<SpriteRenderer>().sprite = Warrior;
                break;
            default:
                gameObject.GetComponent<SpriteRenderer>().sprite = Goblin;
                break;
        }
    }
}

