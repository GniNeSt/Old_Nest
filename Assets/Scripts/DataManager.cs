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
        else if(enemyname == "Gnoll")
            return data.Gnoll;
        else if(enemyname == "Chicken")
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
        else if(enemyname == "ArcherMob")
            return data.ArcherMob;
        else if(enemyname == "KnightMob")
            return data.KnightMob;
        else if(enemyname == "MageMob")
            return data.MageMob;
        else if(enemyname == "WarriorMob")
            return data.WarriorMob;
        else
            return data.Goblin;
    }
    public Companion giveCompanion(string companion){
        if(companion == "ArcherMob")
        {
            return data.Archer;
        }
        else if(companion == "KinghtMob")
        {
            return data.Knight;
        }
        else if (companion == "MageMob")
        {
            return data.Mage;
        }
        else if (companion == "WarriorMob")
        {
            return data.Warrior;
        }
        else
            return data.Knight;
    }
}


[System.Serializable]
public class ChoicementSuccess
{
    public int needviolence, needsane, violence, sane;
    public string ment;
}

[System.Serializable]
public class ChoicementFail
{
    public int violence,sane;
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
    public ChoiceEach first,second,third,fourth;
}

[System.Serializable]
public class Companion
{
    public int coefficentviolence, coefficentsane;
}


[System.Serializable]
public class Data
{
    public Choice Goblin, Gnoll, Chicken, Wolf, Boar, Ork, 
                  GodStatue, Lake, Mimic, TreasureChest,
                  ArcherMob, KnightMob, MageMob, WarriorMob;
    public Companion Archer,Knight,Mage,Warrior;

}