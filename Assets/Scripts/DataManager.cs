using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager
{
    public Data data;
    
    public DataManager() {
        data = JsonUtility.FromJson<Data>(File.ReadAllText(Application.dataPath + "/Table/choicement.json"));
    }

    public Choice giveChoice(string enemyname){
        if(enemyname == "Goblin")
           return data.Goblin; 
        else if(enemyname == "GNoll")
            return data.Gnoll;
        else if(enemyname == "Wyvern")
            return data.Chicken;
        else if(enemyname == "Wolf")
            return data.Wolf;
        else if(enemyname == "Boar")
            return data.Boar;
        else if(enemyname == "Ork")
            return data.Ork;
        else if(enemyname == "GodStatue")
            return data.GodStatue;
        else if(enemyname == "Lake")
            return data.Lake;
        else if(enemyname == "Mimic")
            return data.Mimic;
        else if(enemyname == "TreasureChest")
            return data.TreasureChest;
        else if(enemyname == "Archer")
            return data.ArcherMob;
        else if(enemyname == "Knight")
            return data.KnightMob;
        else if(enemyname == "Mage")
            return data.MageMob;
        else if(enemyname == "Warrior")
            return data.WarriorMob;
        else
            return data.Goblin;
    }
}


[System.Serializable]
public class ChoicementSuccess
{
    public int needviolence;
    public int needsane;
    public int violence;
    public int sane;
    public string ment;
}

[System.Serializable]
public class ChoicementFail
{
    public int violence;
    public int sane;
    public string ment;
}

[System.Serializable]
public class ChoiceEach
{
    public string ment;
    public ChoicementSuccess success;
    public ChoicementFail fail;
}

[System.Serializable]
public class Choice
{   
    public ChoiceEach first;
    public ChoiceEach second;
    public ChoiceEach third;
    public ChoiceEach fourth;
}

[System.Serializable]
public class Companion
{
    public int coefficentviolence;
    public int coefficentsane;
}


[System.Serializable]
public class Data
{
    public Choice Goblin;
    public Choice Gnoll;
    public Choice Chicken;
    public Choice Wolf;
    public Choice Boar;
    public Choice Ork;
    public Choice GodStatue;
    public Choice Lake;
    public Choice Mimic;
    public Choice TreasureChest;
    public Choice ArcherMob;
    public Choice KnightMob;
    public Choice MageMob;
    public Choice WarriorMob;
    public Companion Archer;
    public Companion Knight;
    public Companion Mage;
    public Companion Warrior;

}