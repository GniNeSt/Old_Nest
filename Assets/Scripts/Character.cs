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
    public Sprite Goblin, Gnoll, Chicken, Wolf, Boar, Ork, 
                  GodStatue, Lake, Mimic, TreasureChest,
                  ArcherMob, KnightMob, MageMob, WarriorMob;
    public void Initialize(string thisname)
    {   
        enemyname = thisname;
        dataManager = new DataManager();
        choiceManager = choiceManagerObject.GetComponent<ChoiceManager>();

        choice = dataManager.giveChoice(enemyname);
        if (enemyname == "ArcherMob" || enemyname == "KnightMob" || enemyname == "WarriorMob" || enemyname == "MageMob")
            choiceManager.SetChoice(choice,dataManager.giveCompanion(enemyname));
        else
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
            case "ArcherMob":
                gameObject.GetComponent<SpriteRenderer>().sprite = ArcherMob;
                break;
            case "KnightMob":
                gameObject.GetComponent<SpriteRenderer>().sprite = KnightMob;
                break;
            case "MageMob":
                gameObject.GetComponent<SpriteRenderer>().sprite = MageMob;
                break;
            case "WarriorMob":
                gameObject.GetComponent<SpriteRenderer>().sprite = WarriorMob;
                break;
            default:
                gameObject.GetComponent<SpriteRenderer>().sprite = Goblin;
                break;
        }
    }
}

